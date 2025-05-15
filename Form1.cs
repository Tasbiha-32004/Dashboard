using System.Data;
using System.Data.OleDb;

namespace elib
{
    public partial class Form1 : Form
    {
        private bool isSignUpMode = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate roles in ComboBox
            cmbRole.Items.Add("User");
            cmbRole.Items.Add("Admin");
            cmbRole.SelectedIndex = 0; // Default to "User"
            SetFormMode();
        }

        private void SetFormMode()
        {
            if (isSignUpMode)
            {
                lblTitle.Text = "Sign Up";
                btnSwitchMode.Text = "Switch to Login";
                btnSubmit.Text = "Sign Up";
                lblError.Text = "";
                cmbRole.Visible = true;
                lblRole.Visible = true;
            }
            else
            {
                lblTitle.Text = "Login";
                btnSwitchMode.Text = "Switch to Sign Up";
                btnSubmit.Text = "Login";
                lblError.Text = "";
                cmbRole.Visible = false;
                lblRole.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Please enter both Username and Password.";
                return;
            }

            if (isSignUpMode)
            {
                SignUpUser(username, password);
            }
            else
            {
                LoginUser(username, password);
            }
        }

        private void LoginUser(string username, string password)
        {
            string query = "SELECT UserID, Role FROM USERS WHERE Username = ? AND Password = ?";
            OleDbParameter[] parameters = {
                new OleDbParameter("?", username),
                new OleDbParameter("?", password)
            };

            DataTable result = DatabaseHelper.ExecuteSelect(query, parameters);

            if (result.Rows.Count == 1)
            {
                int id = Convert.ToInt32(result.Rows[0]["UserID"]);
                string role = result.Rows[0]["Role"].ToString();

                User loggedInUser = new User(id, role, username);

                this.Hide();

                if (role == "Admin")
                {
                    AdminDashboardForm adminDashboard = new AdminDashboardForm();
                    adminDashboard.Show();
                }
                else
                {
                    UserDashboardForm userDashboard = new UserDashboardForm(loggedInUser);
                    userDashboard.Show();
                }
            }
            else
            {
                lblError.Text = "Invalid Username or Password.";
            }
        }

        private void SignUpUser(string username, string password)
        {
            string checkQuery = "SELECT COUNT(*) FROM USERS WHERE Username = ?";
            OleDbParameter[] checkParams = { new OleDbParameter("?", username) };
            DataTable checkResult = DatabaseHelper.ExecuteSelect(checkQuery, checkParams);

            int userCount = Convert.ToInt32(checkResult.Rows[0][0]);

            if (userCount > 0)
            {
                lblError.Text = "Username already exists. Please choose another one.";
                return;
            }

            string role = cmbRole.SelectedItem.ToString();

            string insertQuery = "INSERT INTO USERS (Username, Password, Role) VALUES (?, ?, ?)";
            OleDbParameter[] insertParams = {
                new OleDbParameter("?", username),
                new OleDbParameter("?", password),
                new OleDbParameter("?", role)
            };

            DatabaseHelper.ExecuteNonQuery(insertQuery, insertParams);

            lblError.Text = "Sign Up successful. You can now log in.";
            isSignUpMode = false;
            SetFormMode();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            isSignUpMode = !isSignUpMode;
            SetFormMode();
        }
    }
}
