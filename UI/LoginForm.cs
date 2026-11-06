using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class LoginForm : Form
    {
        private string eyeOpenPath;
        private string eyeClosedPath;
        private bool isPasswordVisible = false;

        private readonly UserController _userController;

        public LoginForm()
        {
            InitializeComponent();

            _userController = new UserController();

            InitializeIconPaths();
        }

        private void InitializeIconPaths()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            DirectoryInfo francisFolder = Directory.GetParent(baseDirectory)?.Parent?.Parent?.Parent?.Parent;

            string imagesFolder;

            if (francisFolder != null)
            {
                imagesFolder = Path.Combine(francisFolder.FullName, "Images");
            }
            else
            {
                imagesFolder = Path.Combine(baseDirectory, "Images");
            }

            eyeOpenPath = Path.Combine(imagesFolder, "eye_open.png");
            eyeClosedPath = Path.Combine(imagesFolder, "eye_closed.png");

            txtPassword.PasswordChar = '●';
            picEyeIcon.SizeMode = PictureBoxSizeMode.Zoom;

            if (File.Exists(eyeClosedPath))
            {
                picEyeIcon.Image = Image.FromFile(eyeClosedPath);
            }
            else
            {
                MessageBox.Show($"Could not find image assets at target path:\n{eyeClosedPath}",
                                "Asset Path Tracking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            picEyeIcon.Click += new EventHandler(picEyeIcon_Click);
        }

        private void TogglePasswordVisibility()
        {
            try
            {
                if (isPasswordVisible)
                {
                    txtPassword.PasswordChar = '●';

                    picEyeIcon.Image = Image.FromFile(eyeClosedPath);
                }
                else
                {
                    txtPassword.PasswordChar = '\0';
                    picEyeIcon.Image = Image.FromFile(eyeOpenPath);
                }

                isPasswordVisible = !isPasswordVisible;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading eye icon: {ex.Message}");
            }
        }

        private void picEyeIcon_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text; 
            UserModel user = _userController.Login(username, password, out string errorMsg);

            if (user != null)
            {
                MessageBox.Show($"Welcome back, {user.Username}!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (user.IsAdmin)
                {
                    MainForm mainForm = new MainForm(user);
                    mainForm.Show();
                }
                else
                {
                    MainForm mainForm = new MainForm(user);
                    mainForm.Show();
                }

                this.Hide(); 
            }
            else
            {
                MessageBox.Show(errorMsg, "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}