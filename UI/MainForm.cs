using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard dashboardForm = new FrmDashboard(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(dashboardForm);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FrmDashboard dashboardForm = new FrmDashboard(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(dashboardForm);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            FrmUsers usersForm = new FrmUsers(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(usersForm);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            FrmStudents studentsForm = new FrmStudents(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(studentsForm);
        }

        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            FrmEnrollment enrollmentForm = new FrmEnrollment(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(enrollmentForm);
        }

        private void btnAssement_Click(object sender, EventArgs e)
        {
            FrmAssesment assesmentForm = new FrmAssesment(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(assesmentForm);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            FrmPayment paymentForm = new FrmPayment(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(paymentForm);
        }

        private void btnPaymentHistory_Click(object sender, EventArgs e)
        {
            FrmPaymentHistory paymentHistoryForm = new FrmPaymentHistory(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(paymentHistoryForm);
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            FrmReports reportsForm = new FrmReports(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(reportsForm);
        }

        private void btnaccountsearch_Click(object sender, EventArgs e)
        {
            FrmAccountSearch accountSearchForm = new FrmAccountSearch(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(accountSearchForm);
        }

        private void btnSections_Click(object sender, EventArgs e)
        {
            FrmSections sectionsForm = new FrmSections(_currentUser);
            mainpanel.Controls.Clear();
            LoadFormIntoPanel(sectionsForm);
        }
    }
}
    
    

    
