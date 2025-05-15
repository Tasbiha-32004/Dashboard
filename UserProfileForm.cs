using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace elib
{
    public partial class UserProfileForm : Form
    {
        private User loggedInUser; //Stores the user info passed from the login or dashboard form.

        //Accepts a User object when form is created.
        //shows username and role
        //populates two DataGrids:
        public UserProfileForm(User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
            LoadUserProfile();
            LoadBorrowedBooksHistory();
        }

        private void LoadUserProfile()
        {
            lblUsername.Text = $"{loggedInUser.Username}";
            lblRole.Text = $"{loggedInUser.Role}";
        }


        private void LoadBorrowedBooksHistory()
        {
            // Define columns for dgvActiveBorrowedBooks if they are not already defined
            if (dgvActiveBorrowedBooks.Columns.Count == 0)
            {
                dgvActiveBorrowedBooks.Columns.Add("Title", "Title");
                dgvActiveBorrowedBooks.Columns.Add("Book_ID", "Book ID");
                dgvActiveBorrowedBooks.Columns.Add("BorrowDate", "Borrow Date");
                dgvActiveBorrowedBooks.Columns.Add("DueDate", "Due Date");
                dgvActiveBorrowedBooks.Columns.Add("Status", "Status");
            }

            // Query to retrieve active borrowed books for the logged-in user
            string query = @"SELECT B.Title, BB.Book_ID, BB.BorrowDate, BB.DueDate, BB.Status 
                     FROM BORROWED_BOOKS BB
                     JOIN BOOKS B ON BB.Book_ID = B.Book_ID
                     WHERE BB.UserID = ? AND BB.Status = 'Borrowed'";

            OleDbParameter[] parameters = {
        new OleDbParameter("?", loggedInUser.UserID)
    };

            DataTable dt = DatabaseHelper.ExecuteSelect(query, parameters);
            dgvActiveBorrowedBooks.Rows.Clear(); // Clear existing rows in Active Borrowed Books grid

            foreach (DataRow row in dt.Rows)
            {
                dgvActiveBorrowedBooks.Rows.Add(
                    row["Title"].ToString(),
                    row["Book_ID"].ToString(), // hidden column
                    Convert.ToDateTime(row["BorrowDate"]).ToShortDateString(),
                    Convert.ToDateTime(row["DueDate"]).ToShortDateString(),
                    row["Status"].ToString()
                );
            }

            // Define columns for dgvBorrowedHistory if they are not already defined
            if (dgvBorrowedHistory.Columns.Count == 0)
            {
                dgvBorrowedHistory.Columns.Add("Title", "Title");
                dgvBorrowedHistory.Columns.Add("BorrowDate", "Borrow Date");
                dgvBorrowedHistory.Columns.Add("ReturnDate", "Return Date");
                dgvBorrowedHistory.Columns.Add("Status", "Status");
            }

            // Query to retrieve borrow history for the logged-in user
            string historyQuery = @"SELECT B.Title, BH.BorrowDate, BH.ReturnDate, BH.Status 
                            FROM BORROWED_HISTORY BH
                            JOIN BOOKS B ON BH.Book_ID = B.Book_ID
                            WHERE BH.UserID = ?";

            OleDbParameter[] historyParameters = {
             new OleDbParameter("?", loggedInUser.UserID)
             };

            DataTable historyDt = DatabaseHelper.ExecuteSelect(historyQuery, historyParameters);
            dgvBorrowedHistory.Rows.Clear(); // Clear existing rows in Borrowed History grid

            foreach (DataRow row in historyDt.Rows)
            {
                dgvBorrowedHistory.Rows.Add(
                    row["Title"].ToString(),
                    Convert.ToDateTime(row["BorrowDate"]).ToShortDateString(),
                    Convert.ToDateTime(row["ReturnDate"]).ToShortDateString(),
                    row["Status"].ToString()
                );
            }
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            // Check if a book is selected in the Active Borrowed Books data grid
            if (dgvActiveBorrowedBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to return.");
                return;
            }

            // Get the selected row from the Active Borrowed Books grid
            var selectedRow = dgvActiveBorrowedBooks.SelectedRows[0];
            string bookId = selectedRow.Cells["Book_ID"].Value.ToString(); // Book_ID column in Active Borrowed Books grid
            DateTime borrowDate = Convert.ToDateTime(selectedRow.Cells["BorrowDate"].Value); // BorrowDate column in Active Borrowed Books grid
            int userId = loggedInUser.UserID; // Assuming loggedInUser is available

            // Ensure the bookId is no longer than 26 characters
            if (bookId.Length > 26)
            {
                bookId = bookId.Substring(0, 26);  // Truncate the bookId to 26 characters
            }

            // Step 1: Check if the Book_ID exists in the BOOKS table
            string checkQuery = "SELECT COUNT(*) FROM BOOKS WHERE Book_ID = ?";
            OleDbParameter[] checkParams = new OleDbParameter[]
            {
        new OleDbParameter("?", bookId)
            };

            DataTable checkResult = DatabaseHelper.ExecuteSelect(checkQuery, checkParams);
            int bookCount = Convert.ToInt32(checkResult.Rows[0][0]);

            if (bookCount == 0)
            {
                MessageBox.Show("The book does not exist in the library.");
                return;
            }

            // Step 2: Update the BORROWED_BOOKS table to set the status to 'Returned'
            string updateQuery = "UPDATE BORROWED_BOOKS SET Status = ? WHERE Book_ID = ? AND UserID = ?";
            OleDbParameter[] updateParams = new OleDbParameter[]
            {
        new OleDbParameter("?", "Returned"),
        new OleDbParameter("?", bookId),
        new OleDbParameter("?", userId)
            };
            DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams);

            // Step 3: Insert the return record into the BORROWED_HISTORY table
            DateTime returnDate = DateTime.Now;
            string historyQuery = "INSERT INTO BORROWED_HISTORY (UserID, Book_ID, BorrowDate, ReturnDate, Status) VALUES (?, ?, ?, ?, ?)";
            OleDbParameter[] historyParams = new OleDbParameter[]
            {
        new OleDbParameter("?", userId),
        new OleDbParameter("?", bookId),
        new OleDbParameter("?", borrowDate),
        new OleDbParameter("?", returnDate),
        new OleDbParameter("?", "Returned")
            };
            DatabaseHelper.ExecuteNonQuery(historyQuery, historyParams);

            // Step 4: Update the CopiesAvailable in the BOOKS table
            string updateBookCopiesQuery = "UPDATE BOOKS SET CopiesAvailable = CopiesAvailable + 1 WHERE Book_ID = ?";
            OleDbParameter[] updateBookCopiesParams = new OleDbParameter[]
            {
        new OleDbParameter("?", bookId)
            };
            DatabaseHelper.ExecuteNonQuery(updateBookCopiesQuery, updateBookCopiesParams);

            // Step 5: Refresh both data grids
            LoadBorrowedBooksHistory();  // Refresh Active Borrowed Books and Borrowed History grids

            MessageBox.Show("Book returned successfully!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
