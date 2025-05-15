namespace elib
{
    partial class UserProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileForm));
            dgvActiveBorrowedBooks = new DataGridView();
            lblUsername = new Label();
            lblRole = new Label();
            btnReturnBook = new Button();
            dgvBorrowedHistory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvActiveBorrowedBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedHistory).BeginInit();
            SuspendLayout();
            // 
            // dgvActiveBorrowedBooks
            // 
            dgvActiveBorrowedBooks.AllowUserToAddRows = false;
            dgvActiveBorrowedBooks.AllowUserToDeleteRows = false;
            dgvActiveBorrowedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActiveBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActiveBorrowedBooks.Location = new Point(324, 347);
            dgvActiveBorrowedBooks.Name = "dgvActiveBorrowedBooks";
            dgvActiveBorrowedBooks.ReadOnly = true;
            dgvActiveBorrowedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActiveBorrowedBooks.Size = new Size(449, 377);
            dgvActiveBorrowedBooks.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial Unicode MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(468, 133);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(76, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "USER:";
            lblUsername.Click += label1_Click;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Arial Unicode MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(393, 190);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(75, 25);
            lblRole.TabIndex = 2;
            lblRole.Text = "ROLE:";
            // 
            // btnReturnBook
            // 
            btnReturnBook.AutoSize = true;
            btnReturnBook.Font = new Font("Arial Unicode MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturnBook.Location = new Point(78, 200);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(139, 39);
            btnReturnBook.TabIndex = 3;
            btnReturnBook.Text = "Return Book";
            btnReturnBook.UseVisualStyleBackColor = true;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // dgvBorrowedHistory
            // 
            dgvBorrowedHistory.AllowUserToAddRows = false;
            dgvBorrowedHistory.AllowUserToDeleteRows = false;
            dgvBorrowedHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrowedHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedHistory.Location = new Point(859, 347);
            dgvBorrowedHistory.MultiSelect = false;
            dgvBorrowedHistory.Name = "dgvBorrowedHistory";
            dgvBorrowedHistory.ReadOnly = true;
            dgvBorrowedHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowedHistory.Size = new Size(467, 377);
            dgvBorrowedHistory.TabIndex = 4;
            dgvBorrowedHistory.CellContentClick += dataGridView1_CellContentClick;
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1370, 749);
            Controls.Add(dgvBorrowedHistory);
            Controls.Add(btnReturnBook);
            Controls.Add(lblRole);
            Controls.Add(lblUsername);
            Controls.Add(dgvActiveBorrowedBooks);
            Name = "UserProfileForm";
            Text = "UserProfileForm";
            WindowState = FormWindowState.Maximized;
            Load += UserProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvActiveBorrowedBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvActiveBorrowedBooks;
        private Label lblUsername;
        private Label lblRole;
        private Button btnReturnBook;
        private DataGridView dgvBorrowedHistory;
    }
}