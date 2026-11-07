using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmStudents : Form
    {
        public FrmStudents(UserModel userModel)
        {
            InitializeComponent();
            if (userModel.IsAdmin)
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
