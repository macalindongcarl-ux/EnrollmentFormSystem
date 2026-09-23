using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EnrollmentFormSystem
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {


            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
              string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(
                    "Username and password are required.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;

            }

            using (SqlConnection conn = Database.GetConnection())
            {
                string query = @"
                    SELECT UserID, Username, FullName, Role
                    FROM Users
                    WHERE Username = @Username
                    AND Password = @Password
                    AND IsActive = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@Username",
                        txtUsername.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Password",
                        txtPassword.Text);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Session.UserID =
                                Convert.ToInt32(reader["UserID"]);

                            Session.Username =
                                reader["Username"].ToString();

                            Session.FullName =
                                reader["FullName"].ToString();

                            Session.Role =
                                reader["Role"].ToString();

                            MainForm main = new MainForm();

                            Hide();

                            main.ShowDialog();

                            Show();

                            txtPassword.Clear();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Invalid username or password.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }



                }
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {

        }
    }
        }
            