namespace elib
{
    partial class AdminDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            tabControlAdmin = new TabControl();
            BooksTab = new TabPage();
            label10 = new Label();
            btnUpdateBook = new Button();
            btnDeleteBook = new Button();
            txtBookID = new TextBox();
            dgvBooks = new DataGridView();
            label5 = new Label();
            txtImageURL = new TextBox();
            label4 = new Label();
            numCopies = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            txtAuthor = new TextBox();
            cmbCategory = new ComboBox();
            label1 = new Label();
            txtTitle = new TextBox();
            btnAddBook = new Button();
            CategoriesTab = new TabPage();
            label11 = new Label();
            btnDeleteCategory = new Button();
            txtCategoryID = new TextBox();
            label6 = new Label();
            dgvCategories = new DataGridView();
            btnAddCategory = new Button();
            txtCategoryName = new TextBox();
            UsersTab = new TabPage();
            label12 = new Label();
            txtUserID = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnDeleteUser = new Button();
            dgvUsers = new DataGridView();
            btnAddUser = new Button();
            cmbUserRole = new ComboBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            BorrowedTab = new TabPage();
            dgvBorrowedBooks = new DataGridView();
            tabControlAdmin.SuspendLayout();
            BooksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCopies).BeginInit();
            CategoriesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            UsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            BorrowedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            SuspendLayout();
            // 
            // tabControlAdmin
            // 
            tabControlAdmin.Controls.Add(BooksTab);
            tabControlAdmin.Controls.Add(CategoriesTab);
            tabControlAdmin.Controls.Add(UsersTab);
            tabControlAdmin.Controls.Add(BorrowedTab);
            tabControlAdmin.Location = new Point(2, 1);
            tabControlAdmin.Name = "tabControlAdmin";
            tabControlAdmin.SelectedIndex = 0;
            tabControlAdmin.Size = new Size(1364, 744);
            tabControlAdmin.TabIndex = 0;
            // 
            // BooksTab
            // 
            BooksTab.BackgroundImage = (Image)resources.GetObject("BooksTab.BackgroundImage");
            BooksTab.Controls.Add(label10);
            BooksTab.Controls.Add(btnUpdateBook);
            BooksTab.Controls.Add(btnDeleteBook);
            BooksTab.Controls.Add(txtBookID);
            BooksTab.Controls.Add(dgvBooks);
            BooksTab.Controls.Add(label5);
            BooksTab.Controls.Add(txtImageURL);
            BooksTab.Controls.Add(label4);
            BooksTab.Controls.Add(numCopies);
            BooksTab.Controls.Add(label3);
            BooksTab.Controls.Add(label2);
            BooksTab.Controls.Add(txtAuthor);
            BooksTab.Controls.Add(cmbCategory);
            BooksTab.Controls.Add(label1);
            BooksTab.Controls.Add(txtTitle);
            BooksTab.Controls.Add(btnAddBook);
            BooksTab.Location = new Point(4, 24);
            BooksTab.Name = "BooksTab";
            BooksTab.Padding = new Padding(3);
            BooksTab.Size = new Size(1356, 716);
            BooksTab.TabIndex = 0;
            BooksTab.Text = "Manage Books";
            BooksTab.UseVisualStyleBackColor = true;
            BooksTab.Click += BooksTab_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Unicode MS", 14.25F);
            label10.Location = new Point(294, 126);
            label10.Name = "label10";
            label10.Size = new Size(81, 25);
            label10.TabIndex = 15;
            label10.Text = "Book ID";
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Font = new Font("Arial Unicode MS", 14.25F, FontStyle.Bold);
            btnUpdateBook.Location = new Point(86, 334);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(111, 35);
            btnUpdateBook.TabIndex = 14;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Font = new Font("Arial Unicode MS", 14.25F, FontStyle.Bold);
            btnDeleteBook.Location = new Point(86, 273);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(111, 35);
            btnDeleteBook.TabIndex = 13;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // txtBookID
            // 
            txtBookID.Font = new Font("Segoe UI", 14.25F);
            txtBookID.Location = new Point(381, 126);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(174, 33);
            txtBookID.TabIndex = 12;
            // 
            // dgvBooks
            // 
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(591, 103);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.Size = new Size(759, 607);
            dgvBooks.TabIndex = 11;
            dgvBooks.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Unicode MS", 14.25F);
            label5.Location = new Point(284, 466);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 10;
            label5.Text = "Image URL";
            // 
            // txtImageURL
            // 
            txtImageURL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtImageURL.Location = new Point(400, 462);
            txtImageURL.Name = "txtImageURL";
            txtImageURL.Size = new Size(156, 29);
            txtImageURL.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Unicode MS", 14.25F);
            label4.Location = new Point(294, 387);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 8;
            label4.Text = "Copies";
            label4.Click += label4_Click;
            // 
            // numCopies
            // 
            numCopies.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numCopies.Location = new Point(381, 379);
            numCopies.Name = "numCopies";
            numCopies.Size = new Size(174, 33);
            numCopies.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Unicode MS", 14.25F);
            label3.Location = new Point(284, 317);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 6;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Unicode MS", 14.25F);
            label2.Location = new Point(294, 252);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 5;
            label2.Text = "Author";
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 14.25F);
            txtAuthor.Location = new Point(381, 252);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(174, 33);
            txtAuthor.TabIndex = 4;
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(381, 317);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(174, 33);
            cmbCategory.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Unicode MS", 14.25F);
            label1.Location = new Point(303, 189);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 2;
            label1.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 14.25F);
            txtTitle.Location = new Point(381, 189);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(174, 33);
            txtTitle.TabIndex = 1;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Arial Unicode MS", 14.25F, FontStyle.Bold);
            btnAddBook.Location = new Point(86, 215);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(111, 35);
            btnAddBook.TabIndex = 0;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // CategoriesTab
            // 
            CategoriesTab.BackgroundImage = (Image)resources.GetObject("CategoriesTab.BackgroundImage");
            CategoriesTab.Controls.Add(label11);
            CategoriesTab.Controls.Add(btnDeleteCategory);
            CategoriesTab.Controls.Add(txtCategoryID);
            CategoriesTab.Controls.Add(label6);
            CategoriesTab.Controls.Add(dgvCategories);
            CategoriesTab.Controls.Add(btnAddCategory);
            CategoriesTab.Controls.Add(txtCategoryName);
            CategoriesTab.Location = new Point(4, 24);
            CategoriesTab.Name = "CategoriesTab";
            CategoriesTab.Padding = new Padding(3);
            CategoriesTab.Size = new Size(1356, 716);
            CategoriesTab.TabIndex = 1;
            CategoriesTab.Text = "Manage Categories";
            CategoriesTab.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Unicode MS", 14.25F);
            label11.Location = new Point(281, 189);
            label11.Name = "label11";
            label11.Size = new Size(115, 25);
            label11.TabIndex = 6;
            label11.Text = "Category ID";
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Font = new Font("Arial Unicode MS", 14.25F, FontStyle.Bold);
            btnDeleteCategory.Location = new Point(79, 272);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(175, 39);
            btnDeleteCategory.TabIndex = 5;
            btnDeleteCategory.Text = "Delete Category";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Font = new Font("Segoe UI", 14.25F);
            txtCategoryID.Location = new Point(402, 181);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(160, 33);
            txtCategoryID.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Unicode MS", 14.25F);
            label6.Location = new Point(281, 300);
            label6.Name = "label6";
            label6.Size = new Size(148, 25);
            label6.TabIndex = 3;
            label6.Text = "Category Name";
            // 
            // dgvCategories
            // 
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(593, 101);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.Size = new Size(757, 598);
            dgvCategories.TabIndex = 2;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Font = new Font("Arial Unicode MS", 14.25F, FontStyle.Bold);
            btnAddCategory.Location = new Point(79, 202);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(175, 39);
            btnAddCategory.TabIndex = 1;
            btnAddCategory.Text = "Add Category";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Segoe UI", 14.25F);
            txtCategoryName.Location = new Point(435, 297);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(127, 33);
            txtCategoryName.TabIndex = 0;
            // 
            // UsersTab
            // 
            UsersTab.BackgroundImage = (Image)resources.GetObject("UsersTab.BackgroundImage");
            UsersTab.Controls.Add(label12);
            UsersTab.Controls.Add(txtUserID);
            UsersTab.Controls.Add(label9);
            UsersTab.Controls.Add(label8);
            UsersTab.Controls.Add(label7);
            UsersTab.Controls.Add(btnDeleteUser);
            UsersTab.Controls.Add(dgvUsers);
            UsersTab.Controls.Add(btnAddUser);
            UsersTab.Controls.Add(cmbUserRole);
            UsersTab.Controls.Add(txtPassword);
            UsersTab.Controls.Add(txtUsername);
            UsersTab.Location = new Point(4, 24);
            UsersTab.Name = "UsersTab";
            UsersTab.Padding = new Padding(3);
            UsersTab.Size = new Size(1356, 716);
            UsersTab.TabIndex = 2;
            UsersTab.Text = "Manage Users";
            UsersTab.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Unicode MS", 14.25F);
            label12.Location = new Point(273, 154);
            label12.Name = "label12";
            label12.Size = new Size(77, 25);
            label12.TabIndex = 10;
            label12.Text = "User ID";
            // 
            // txtUserID
            // 
            txtUserID.Font = new Font("Segoe UI", 14.25F);
            txtUserID.Location = new Point(397, 154);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(173, 33);
            txtUserID.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Unicode MS", 14.25F);
            label9.Location = new Point(283, 353);
            label9.Name = "label9";
            label9.Size = new Size(52, 25);
            label9.TabIndex = 8;
            label9.Text = "Role";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Unicode MS", 14.25F);
            label8.Location = new Point(273, 281);
            label8.Name = "label8";
            label8.Size = new Size(98, 25);
            label8.TabIndex = 7;
            label8.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Unicode MS", 14.25F);
            label7.Location = new Point(273, 212);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 6;
            label7.Text = "Username";
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Font = new Font("Arial Unicode MS", 14.25F, FontStyle.Bold);
            btnDeleteUser.Location = new Point(92, 275);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(97, 31);
            btnDeleteUser.TabIndex = 5;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(596, 102);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(754, 596);
            dgvUsers.TabIndex = 4;
            // 
            // btnAddUser
            // 
            btnAddUser.Font = new Font("Arial Unicode MS", 14.25F, FontStyle.Bold);
            btnAddUser.Location = new Point(92, 206);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(97, 31);
            btnAddUser.TabIndex = 3;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // cmbUserRole
            // 
            cmbUserRole.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbUserRole.FormattingEnabled = true;
            cmbUserRole.Items.AddRange(new object[] { "Admin", "User" });
            cmbUserRole.Location = new Point(397, 353);
            cmbUserRole.Name = "cmbUserRole";
            cmbUserRole.Size = new Size(173, 33);
            cmbUserRole.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F);
            txtPassword.Location = new Point(397, 283);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(173, 33);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14.25F);
            txtUsername.Location = new Point(397, 217);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(173, 33);
            txtUsername.TabIndex = 0;
            // 
            // BorrowedTab
            // 
            BorrowedTab.BackgroundImage = (Image)resources.GetObject("BorrowedTab.BackgroundImage");
            BorrowedTab.Controls.Add(dgvBorrowedBooks);
            BorrowedTab.Location = new Point(4, 24);
            BorrowedTab.Name = "BorrowedTab";
            BorrowedTab.Padding = new Padding(3);
            BorrowedTab.Size = new Size(1356, 716);
            BorrowedTab.TabIndex = 3;
            BorrowedTab.Text = "View borrowed books ";
            BorrowedTab.UseVisualStyleBackColor = true;
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedBooks.Location = new Point(339, 100);
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.Size = new Size(1011, 610);
            dgvBorrowedBooks.TabIndex = 0;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(tabControlAdmin);
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            WindowState = FormWindowState.Maximized;
            Load += AdminDashboardForm_Load;
            tabControlAdmin.ResumeLayout(false);
            BooksTab.ResumeLayout(false);
            BooksTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCopies).EndInit();
            CategoriesTab.ResumeLayout(false);
            CategoriesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            UsersTab.ResumeLayout(false);
            UsersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            BorrowedTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlAdmin;
        private TabPage BooksTab;
        private TabPage CategoriesTab;
        private TabPage UsersTab;
        private TabPage BorrowedTab;
        private Label label5;
        private TextBox txtImageURL;
        private Label label4;
        private NumericUpDown numCopies;
        private Label label3;
        private Label label2;
        private TextBox txtAuthor;
        private ComboBox cmbCategory;
        private Label label1;
        private TextBox txtTitle;
        private Button btnAddBook;
        private DataGridView dgvBooks;
        private TextBox txtCategoryName;
        private DataGridView dgvCategories;
        private Button btnAddCategory;
        private Label label6;
        private Button btnDeleteUser;
        private DataGridView dgvUsers;
        private Button btnAddUser;
        private ComboBox cmbUserRole;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label7;
        private Label label8;
        private Label label9;
        private DataGridView dgvBorrowedBooks;
        private TextBox txtBookID;
        private TextBox txtCategoryID;
        private TextBox txtUserID;
        private Button btnDeleteBook;
        private Button btnUpdateBook;
        private Button btnDeleteCategory;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}