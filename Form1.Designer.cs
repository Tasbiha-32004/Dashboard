namespace elib
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSubmit = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblError = new Label();
            lblTitle = new Label();
            btnSwitchMode = new Button();
            cmbRole = new ComboBox();
            lblRole = new Label();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.AutoSize = true;
            btnSubmit.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(457, 493);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 49);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "button1";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += button1_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(358, 305);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(358, 366);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(437, 305);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(220, 33);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(437, 355);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(220, 33);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(466, 276);
            lblError.Name = "lblError";
            lblError.Size = new Size(32, 15);
            lblError.TabIndex = 5;
            lblError.Text = "Error";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(466, 233);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(72, 30);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "label1";
            // 
            // btnSwitchMode
            // 
            btnSwitchMode.Font = new Font("Arial Unicode MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSwitchMode.Location = new Point(437, 565);
            btnSwitchMode.Name = "btnSwitchMode";
            btnSwitchMode.Size = new Size(164, 31);
            btnSwitchMode.TabIndex = 7;
            btnSwitchMode.Text = "button1";
            btnSwitchMode.UseVisualStyleBackColor = true;
            btnSwitchMode.Click += button1_Click_1;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(437, 410);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(220, 33);
            cmbRole.TabIndex = 8;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(385, 421);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(30, 15);
            lblRole.TabIndex = 9;
            lblRole.Text = "Role";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1370, 749);
            Controls.Add(lblRole);
            Controls.Add(cmbRole);
            Controls.Add(btnSwitchMode);
            Controls.Add(lblTitle);
            Controls.Add(lblError);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(btnSubmit);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblError;
        private Label lblTitle;
        private Button btnSwitchMode;
        private ComboBox cmbRole;
        private Label lblRole;
    }
}
