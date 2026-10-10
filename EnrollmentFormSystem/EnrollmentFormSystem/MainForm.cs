using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnrollmentFormSystem.Properties;
using System.Windows.Forms;

namespace EnrollmentFormSystem
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }







        private void btnStudent_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmstudents());
           
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

        private void btnUsers_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new userfrm());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new FrmDashboard());
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new Reports());
        }

        private void btnPaymentHistory_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new PaymentHistory());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new Payments());

        }

        private void btnaccountsearch_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new AccountSearch());
        }

        private void btnAssement_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new Assesment());
        }

        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new Enrollment());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
               frmLogin login = new frmLogin();
                login.Show();
            }
        }
    }
    }
    
    

    
