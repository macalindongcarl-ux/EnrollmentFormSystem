using Model;

namespace UI
{
    public partial class MainForm : Form
    {
        private readonly UserModel _currentUser;

        public MainForm(UserModel loggedInUser)
        {
            InitializeComponent();
            _currentUser = loggedInUser;
        }
        private void LoadFormIntoPanel(Form childForm)
        {
            mainpanel.Controls.Clear();
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(childForm);
            mainpanel.Tag = childForm;
            childForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConfigureRolePermissions();

            FrmDashboard dashboardForm = new FrmDashboard(_currentUser);
            LoadFormIntoPanel(dashboardForm);
        }
        private void ConfigureRolePermissions()
        {
            string role = _currentUser?.Role ?? string.Empty;

            bool isAdmin = role == "Admin";
            bool isRegistrar = role == "Registrar";
            bool isCashier = role == "Cashier";

            btnUsers.Visible = isAdmin;

            btnStudent.Visible = isAdmin || isRegistrar;
            btnSections.Visible = isAdmin || isRegistrar;
            btnEnrollment.Visible = isAdmin || isRegistrar;
            btnAssement.Visible = isAdmin || isRegistrar;
            btnreports.Visible = isAdmin || isRegistrar;

            btnaccountsearch.Visible = isAdmin || isCashier;
            btnPayment.Visible = isAdmin || isCashier;
            btnPaymentHistory.Visible = isAdmin || isCashier;

            btnDashboard.Visible = true;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard show = new FrmDashboard(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(show);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            FrmUsers show = new FrmUsers(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(show);
        }

        private void btnSections_Click(object sender, EventArgs e)
        {
            FrmSections show = new FrmSections(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(show);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            FrmStudents show = new FrmStudents(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(show);
        }

        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            FrmEnrollment show = new FrmEnrollment(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(show);
        }

        private void btnAssement_Click(object sender, EventArgs e)
        {
            FrmAssesment show = new FrmAssesment(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(show);
        }

        private void btnaccountsearch_Click(object sender, EventArgs e)
        {
            FrmAccountSearch show = new FrmAccountSearch(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(show);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            FrmPayment show = new FrmPayment(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(show);
        }

        private void btnPaymentHistory_Click(object sender, EventArgs e)
        {
            FrmPaymentHistory show = new FrmPaymentHistory(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(show);
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            FrmReports show = new FrmReports(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(show);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
    
    

    
