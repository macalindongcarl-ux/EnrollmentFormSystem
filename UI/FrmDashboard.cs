using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard(UserModel loggedInUser)
        {
            InitializeComponent();

            if (loggedInUser.IsAdmin)
            {
                lblWelcome.Text = "Welcome, Admin! Here's an overview of the system."; 
            }
            else
            {
                lblWelcome.Text = "Welcome, Cashier! Here's an overview of the system.";
            }
        }
    }
}
