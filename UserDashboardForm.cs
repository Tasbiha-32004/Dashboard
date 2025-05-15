using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;

namespace elib
{
    public partial class UserDashboardForm : Form
    {
        private User loggedInUser;
        public UserDashboardForm(User user)
        {
            InitializeComponent();
            picCover.SizeMode = PictureBoxSizeMode.Zoom;
            this.loggedInUser = user;
            LoadCategories();
            LoadBooks();
        }
        private bool categoriesLoaded = false;
        private void LoadCategories()
        {
            string query = "SELECT Category_ID, CategoryName FROM CATEGORIES";
            DataTable dt = DatabaseHelper.ExecuteSelect(query);

            // Add "None" option manually
            DataRow noneRow = dt.NewRow();
            noneRow["Category_ID"] = DBNull.Value;
            noneRow["CategoryName"] = "None";
            dt.Rows.InsertAt(noneRow, 0); // Insert at the top

            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "Category_ID";
            cmbCategory.SelectedIndex = 0; // Set default to "None"
            categoriesLoaded = true;
        }

        private void LoadBooks(string categoryId = null, string searchQuery = null)
        {
            string query = "SELECT Book_ID, Title, Author, Description, ImageData, CopiesAvailable FROM BOOKS WHERE 1=1";

            List<OleDbParameter> parameters = new List<OleDbParameter>();

            //filter books by category
            if (!string.IsNullOrEmpty(categoryId))
            {
                query += " AND Category_ID = ?";
                parameters.Add(new OleDbParameter("?", categoryId));
            }
            //filter by search keywords if provided
            if (!string.IsNullOrEmpty(searchQuery))
            {
                query += " AND (UPPER(Title) LIKE UPPER(?) OR UPPER(Author) LIKE UPPER(?))";
                parameters.Add(new OleDbParameter("?", "%" + searchQuery + "%"));
                parameters.Add(new OleDbParameter("?", "%" + searchQuery + "%"));
            }

            DataTable dt = DatabaseHelper.ExecuteSelect(query, parameters.ToArray());
            FillBookGrid(dt);
        }

        //Clears existing data in dgvBooks.
        //Displays books row-by-row in the grid.
        private void FillBookGrid(DataTable dt)
        {
            dgvBooks.Rows.Clear();
            dgvBooks.Columns.Clear();
            dgvBooks.AutoGenerateColumns = false;

            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn
            {
                HeaderText = "Cover",
                Name = "Cover",
                Width = 50,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgvBooks.Columns.Add(imgColumn);

            dgvBooks.Columns.Add("Book_ID", "Book_ID");
            dgvBooks.Columns["Book_ID"].Visible = false;
            dgvBooks.Columns.Add("Title", "Title");
            dgvBooks.Columns.Add("Author", "Author");

            foreach (DataRow row in dt.Rows)
            {
                byte[] imgBytes = row["ImageData"] as byte[];
                Image img = null;

                if (imgBytes != null && imgBytes.Length > 0)
                {
                    img = Utils.ByteArrayToImage(imgBytes);
                }

                dgvBooks.Rows.Add(img, row["Book_ID"], row["Title"], row["Author"]);
            }
        }
        private void UserDashboardForm_Load(object sender, EventArgs e)
        {
            txtSearch.PlaceholderText = "Search by title or author...";
            btnSearch.Enabled = false;
            btnClearSearch.Visible = false;
        }

        private async void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string bookId = dgvBooks.Rows[e.RowIndex].Cells["Book_ID"].Value?.ToString();
            if (string.IsNullOrEmpty(bookId)) return;

            string query = "SELECT Description, ImageData FROM BOOKS WHERE Book_ID = ?";
            var param = new OleDbParameter[] { new OleDbParameter("?", bookId) };

            await Task.Run(() =>
            {
                DataTable dt = DatabaseHelper.ExecuteSelect(query, param);
                if (dt.Rows.Count == 0) return;

                string description = dt.Rows[0]["Description"]?.ToString();
                byte[] imageBytes = dt.Rows[0]["ImageData"] as byte[];

                Image image = null;
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    try
                    {
                        image = Utils.ByteArrayToImage(imageBytes);
                    }
                    catch
                    {
                        image = null;
                    }
                }

                // Update UI safely on the main thread
                Invoke(new Action(() =>
                {
                    rtbDescription.Text = description ?? "No description available.";

                    if (picCover.Image != null) //cleanup logic
                    {
                        picCover.Image.Dispose();
                        picCover.Image = null;
                    }
                    picCover.Image = image;
                    btnBorrow.Tag = bookId;
                    btnBorrow.Enabled = true;
                }));
            });
        }
        //checks available copies
        //insert into BORROWED_BOOKS
        //Update availability
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (btnBorrow.Tag == null) return;

            string bookId = btnBorrow.Tag.ToString();

            // Step 1: Check if the book has available copies
            string checkQuery = "SELECT CopiesAvailable FROM BOOKS WHERE Book_ID = ?";
            var checkParam = new OleDbParameter[] { new OleDbParameter("?", bookId) };
            DataTable result = DatabaseHelper.ExecuteSelect(checkQuery, checkParam);

            if (result.Rows.Count > 0)
            {
                int available = Convert.ToInt32(result.Rows[0]["CopiesAvailable"]);

                // Step 2: If there are available copies, proceed with borrowing
                if (available > 0)
                {
                    // Step 3: Insert a new record into the BORROWED_BOOKS table
                    string borrowQuery = "INSERT INTO BORROWED_BOOKS (UserID, Book_ID, BorrowDate, DueDate, Status) VALUES (?, ?, ?, ?, ?)";
                    DateTime now = DateTime.Now;
                    DateTime dueDate = now.AddDays(7);  // Set due date 7 days from now (or adjust as needed)

                    var borrowParams = new OleDbParameter[] {
                        new OleDbParameter("?", loggedInUser.UserID),
                        new OleDbParameter("?", bookId),
                        new OleDbParameter("?", now),
                        new OleDbParameter("?", dueDate),
                        new OleDbParameter("?", "Borrowed")  // Initially, the status is "Borrowed"
                    };
                    DatabaseHelper.ExecuteNonQuery(borrowQuery, borrowParams);

                    // Step 4: Update the book's available copies
                    string updateQuery = "UPDATE BOOKS SET CopiesAvailable = CopiesAvailable - 1 WHERE Book_ID = ?";
                    var updateParam = new OleDbParameter[] { new OleDbParameter("?", bookId) };
                    DatabaseHelper.ExecuteNonQuery(updateQuery, updateParam);

                    MessageBox.Show("Book borrowed successfully!");
                    LoadBooks();  // Refresh the books list to show updated copies available
                }
                else
                {
                    MessageBox.Show("No copies available.");
                }
            }
        }
        //loads books filtered by category.
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!categoriesLoaded || cmbCategory.SelectedValue == null || cmbCategory.SelectedIndex == 0)
            {
                LoadBooks(); // Load all books if "None" is selected
            }
            else
            {
                LoadBooks(cmbCategory.SelectedValue.ToString());
            }
        }

        private void picCover_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim();
            LoadBooks(cmbCategory.SelectedValue?.ToString(), searchQuery);
            btnSearch.Visible = false;
            btnClearSearch.Visible = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = !string.IsNullOrWhiteSpace(txtSearch.Text);
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadBooks(cmbCategory.SelectedValue?.ToString());

            // Reset button visibility
            btnClearSearch.Visible = false;
            btnSearch.Visible = true;
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            UserProfileForm profileForm = new UserProfileForm(loggedInUser);
            profileForm.Show();
        }
    }
}
