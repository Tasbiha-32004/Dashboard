using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elib
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadCategories();
            LoadUsers();
            LoadBorrowedBooks();
            LoadCategoriesIntoComboBox();
        }

        private void LoadBooks()
        {
            string query = "SELECT * FROM BOOKS";
            dgvBooks.DataSource = DatabaseHelper.ExecuteSelect(query);

            // Convert byte[] to Image for display
            foreach (DataGridViewRow row in dgvBooks.Rows)
            {
                if (row.Cells["IMAGEDATA"].Value != DBNull.Value)
                {
                    try
                    {
                        byte[] imageData = (byte[])row.Cells["IMAGEDATA"].Value;
                        if (imageData != null && imageData.Length > 0)
                        {
                            using (var ms = new MemoryStream(imageData))
                            {
                                row.Cells["IMAGEDATA"].Value = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            row.Cells["IMAGEDATA"].Value = null;
                        }
                    }
                    catch
                    {
                        row.Cells["IMAGEDATA"].Value = null;
                    }
                }
            }

            // Optional: set the image column layout
            if (dgvBooks.Columns["IMAGEDATA"] is DataGridViewImageColumn imgCol)
            {
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }

        private void LoadCategoriesIntoComboBox()
        {
            string query = "SELECT CATEGORY_ID, CATEGORYNAME FROM CATEGORIES";
            DataTable dt = DatabaseHelper.ExecuteSelect(query);
            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "CATEGORYNAME";
            cmbCategory.ValueMember = "CATEGORY_ID";
        }

        private void BooksTab_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string categoryId = cmbCategory.SelectedValue?.ToString();
            int copies = (int)numCopies.Value;
            string imageUrl = txtImageURL.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(categoryId))
            {
                MessageBox.Show("Please fill all book fields.");
                return;
            }

            byte[] imageData = ConvertImageUrlToBlob(imageUrl);
            string bookId = GetNextBookId();

            string insertQuery = "INSERT INTO BOOKS (BOOK_ID, TITLE, AUTHOR, CATEGORY_ID, COPIESAVAILABLE, IMAGEURL, IMAGEDATA) VALUES (?, ?, ?, ?, ?, ?, ?)";
            OleDbParameter[] parameters = {
                new OleDbParameter("?", bookId),
                new OleDbParameter("?", title),
                new OleDbParameter("?", author),
                new OleDbParameter("?", categoryId),
                new OleDbParameter("?", copies),
                new OleDbParameter("?", imageUrl),
                new OleDbParameter("?", imageData)
            };

            DatabaseHelper.ExecuteNonQuery(insertQuery, parameters);
            MessageBox.Show("Book added.");
            LoadBooks();
        }

        private string GetNextBookId()
        {
            string query = "SELECT BOOK_ID FROM BOOKS";
            DataTable dt = DatabaseHelper.ExecuteSelect(query);

            int maxId = 0;
            foreach (DataRow row in dt.Rows)
            {
                string id = row["BOOK_ID"].ToString();
                if (id.StartsWith("b_"))
                {
                    if (int.TryParse(id.Substring(2), out int num))
                    {
                        if (num > maxId)
                            maxId = num;
                    }
                }
            }
            return $"b_{maxId + 1}";
        }
        private byte[] ConvertImageUrlToBlob(string imageUrl)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    return client.DownloadData(imageUrl);
                }
            }
            catch
            {
                return null;
            }
        }

        private void LoadCategories()
        {
            string query = "SELECT * FROM CATEGORIES";
            dgvCategories.DataSource = DatabaseHelper.ExecuteSelect(query);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }

            string categoryId = GetNextCategoryId();

            string insertQuery = "INSERT INTO CATEGORIES (CATEGORY_ID, CATEGORYNAME) VALUES (?, ?)";
            OleDbParameter[] parameters = {
                new OleDbParameter("?", categoryId),
                new OleDbParameter("?", name)
            };

            DatabaseHelper.ExecuteNonQuery(insertQuery, parameters);
            MessageBox.Show("Category added.");
            LoadCategories();
            LoadCategoriesIntoComboBox();
        }

        private string GetNextCategoryId()
        {
            string query = "SELECT CATEGORY_ID FROM CATEGORIES";
            DataTable dt = DatabaseHelper.ExecuteSelect(query);

            int maxId = 0;
            foreach (DataRow row in dt.Rows)
            {
                string id = row["CATEGORY_ID"].ToString();
                if (id.StartsWith("c_"))
                {
                    if (int.TryParse(id.Substring(2), out int num))
                    {
                        if (num > maxId)
                            maxId = num;
                    }
                }
            }
            return $"c_{maxId + 1}";
        }


        private void LoadUsers()
        {
            string query = "SELECT * FROM USERS";
            dgvUsers.DataSource = DatabaseHelper.ExecuteSelect(query);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbUserRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
                return;

            string insertQuery = "INSERT INTO USERS (Username, Password, Role) VALUES (?, ?, ?)";
            OleDbParameter[] parameters = {
                new OleDbParameter("?", username),
                new OleDbParameter("?", password),
                new OleDbParameter("?", role)
            };
            DatabaseHelper.ExecuteNonQuery(insertQuery, parameters);
            LoadUsers();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text))
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            string query = "DELETE FROM USERS WHERE UserID = ?";
            OleDbParameter[] parameters = {
                new OleDbParameter("?", txtUserID.Text)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("User deleted.");
            LoadUsers();
        }

        private void LoadBorrowedBooks()
        {
            string query = "SELECT * FROM BORROWED_BOOKS";
            dgvBorrowedBooks.DataSource = DatabaseHelper.ExecuteSelect(query);
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookID.Text))
            {
                MessageBox.Show("Please select a book to delete.");
                return;
            }

            string query = "DELETE FROM BOOKS WHERE BOOK_ID = ?";
            OleDbParameter[] parameters = {
                new OleDbParameter("?", txtBookID.Text)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Book deleted.");
            LoadBooks(); // Refresh the DataGridView
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            string bookId = txtBookID.Text.Trim();
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string categoryId = cmbCategory.SelectedValue?.ToString();
            string imageUrl = txtImageURL.Text.Trim();

            if (string.IsNullOrEmpty(bookId) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(categoryId))
            {
                MessageBox.Show("Please fill all fields including Book ID.");
                return;
            }

            byte[] imageData = ConvertImageUrlToBlob(imageUrl);

            string query = "UPDATE BOOKS SET TITLE = ?, AUTHOR = ?, CATEGORY_ID = ?, IMAGEURL = ?, IMAGEDATA = ? WHERE BOOK_ID = ?";
            OleDbParameter[] parameters = {
                new OleDbParameter("?", title),
                new OleDbParameter("?", author),
                new OleDbParameter("?", categoryId),
                new OleDbParameter("?", imageUrl),
                new OleDbParameter("?", imageData),
                new OleDbParameter("?", bookId)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Book updated.");
            LoadBooks();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            string categoryId = txtCategoryID.Text.Trim();
            if (string.IsNullOrEmpty(categoryId))
            {
                MessageBox.Show("Please enter a Category ID to delete.");
                return;
            }

            string query = "DELETE FROM CATEGORIES WHERE CATEGORY_ID = ?";
            OleDbParameter[] parameters = {
                new OleDbParameter("?", categoryId)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Category deleted.");
            LoadCategories();
            LoadCategoriesIntoComboBox();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
