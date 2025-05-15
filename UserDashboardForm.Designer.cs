namespace elib
{
    partial class UserDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboardForm));
            label1 = new Label();
            btnSearch = new Button();
            cmbCategory = new ComboBox();
            txtSearch = new TextBox();
            dgvBooks = new DataGridView();
            picCover = new PictureBox();
            btnBorrow = new Button();
            btnUserProfile = new Button();
            rtbDescription = new RichTextBox();
            btnClearSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCover).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 21);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Search Books:";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(1256, 100);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(102, 46);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(1217, 177);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(140, 33);
            cmbCategory.TabIndex = 2;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(701, 107);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(532, 33);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(678, 216);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowTemplate.Height = 100;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(680, 521);
            dgvBooks.TabIndex = 4;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            // 
            // picCover
            // 
            picCover.Location = new Point(341, 100);
            picCover.Name = "picCover";
            picCover.Size = new Size(245, 260);
            picCover.TabIndex = 5;
            picCover.TabStop = false;
            // 
            // btnBorrow
            // 
            btnBorrow.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrow.Location = new Point(72, 263);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(145, 48);
            btnBorrow.TabIndex = 7;
            btnBorrow.Text = "Borrow Book";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnUserProfile
            // 
            btnUserProfile.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserProfile.Location = new Point(72, 190);
            btnUserProfile.Name = "btnUserProfile";
            btnUserProfile.Size = new Size(145, 51);
            btnUserProfile.TabIndex = 8;
            btnUserProfile.Text = "View Profile";
            btnUserProfile.UseVisualStyleBackColor = true;
            btnUserProfile.Click += btnUserProfile_Click;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(311, 428);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.ReadOnly = true;
            rtbDescription.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbDescription.Size = new Size(306, 267);
            rtbDescription.TabIndex = 9;
            rtbDescription.Text = "";
            // 
            // btnClearSearch
            // 
            btnClearSearch.BackColor = Color.Red;
            btnClearSearch.Font = new Font("Arial Unicode MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearSearch.ForeColor = SystemColors.ActiveCaptionText;
            btnClearSearch.Location = new Point(1256, 100);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(101, 46);
            btnClearSearch.TabIndex = 10;
            btnClearSearch.Text = "X";
            btnClearSearch.UseVisualStyleBackColor = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // UserDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1370, 749);
            Controls.Add(btnClearSearch);
            Controls.Add(rtbDescription);
            Controls.Add(btnUserProfile);
            Controls.Add(btnBorrow);
            Controls.Add(picCover);
            Controls.Add(dgvBooks);
            Controls.Add(txtSearch);
            Controls.Add(cmbCategory);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Name = "UserDashboardForm";
            Text = "UserDashboardForm";
            WindowState = FormWindowState.Maximized;
            Load += UserDashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSearch;
        private ComboBox cmbCategory;
        private TextBox txtSearch;
        private DataGridView dgvBooks;
        private PictureBox picCover;
        private Button btnBorrow;
        private Button btnUserProfile;
        private RichTextBox rtbDescription;
        private Button btnClearSearch;
    }
}