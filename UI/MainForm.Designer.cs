namespace UI
{
    partial class MainForm
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
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnUsers = new Button();
            btnSections = new Button();
            btnStudent = new Button();
            btnEnrollment = new Button();
            btnAssement = new Button();
            btnaccountsearch = new Button();
            btnPayment = new Button();
            btnPaymentHistory = new Button();
            btnreports = new Button();
            btnLogOut = new Button();
            mainpanel = new Panel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 1080);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnDashboard);
            flowLayoutPanel1.Controls.Add(btnUsers);
            flowLayoutPanel1.Controls.Add(btnSections);
            flowLayoutPanel1.Controls.Add(btnStudent);
            flowLayoutPanel1.Controls.Add(btnEnrollment);
            flowLayoutPanel1.Controls.Add(btnAssement);
            flowLayoutPanel1.Controls.Add(btnaccountsearch);
            flowLayoutPanel1.Controls.Add(btnPayment);
            flowLayoutPanel1.Controls.Add(btnPaymentHistory);
            flowLayoutPanel1.Controls.Add(btnreports);
            flowLayoutPanel1.Controls.Add(btnLogOut);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(340, 1080);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = SystemColors.GradientActiveCaption;
            btnDashboard.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Margin = new Padding(0, 0, 0, 8);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(334, 89);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = SystemColors.GradientActiveCaption;
            btnUsers.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnUsers.Location = new Point(0, 97);
            btnUsers.Margin = new Padding(0, 0, 0, 8);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(334, 89);
            btnUsers.TabIndex = 1;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnSections
            // 
            btnSections.BackColor = SystemColors.GradientActiveCaption;
            btnSections.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnSections.Location = new Point(0, 194);
            btnSections.Margin = new Padding(0, 0, 0, 8);
            btnSections.Name = "btnSections";
            btnSections.Size = new Size(334, 89);
            btnSections.TabIndex = 9;
            btnSections.Text = "Sections";
            btnSections.UseVisualStyleBackColor = false;
            btnSections.Click += btnSections_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = SystemColors.GradientActiveCaption;
            btnStudent.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnStudent.Location = new Point(0, 291);
            btnStudent.Margin = new Padding(0, 0, 0, 8);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(334, 89);
            btnStudent.TabIndex = 2;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnEnrollment
            // 
            btnEnrollment.BackColor = SystemColors.GradientActiveCaption;
            btnEnrollment.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnEnrollment.Location = new Point(0, 388);
            btnEnrollment.Margin = new Padding(0, 0, 0, 8);
            btnEnrollment.Name = "btnEnrollment";
            btnEnrollment.Size = new Size(334, 89);
            btnEnrollment.TabIndex = 3;
            btnEnrollment.Text = "Enrollment";
            btnEnrollment.UseVisualStyleBackColor = false;
            btnEnrollment.Click += btnEnrollment_Click;
            // 
            // btnAssement
            // 
            btnAssement.BackColor = SystemColors.GradientActiveCaption;
            btnAssement.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnAssement.Location = new Point(0, 485);
            btnAssement.Margin = new Padding(0, 0, 0, 8);
            btnAssement.Name = "btnAssement";
            btnAssement.Size = new Size(334, 89);
            btnAssement.TabIndex = 4;
            btnAssement.Text = "Assessment";
            btnAssement.UseVisualStyleBackColor = false;
            btnAssement.Click += btnAssement_Click;
            // 
            // btnaccountsearch
            // 
            btnaccountsearch.BackColor = SystemColors.GradientActiveCaption;
            btnaccountsearch.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnaccountsearch.Location = new Point(0, 582);
            btnaccountsearch.Margin = new Padding(0, 0, 0, 8);
            btnaccountsearch.Name = "btnaccountsearch";
            btnaccountsearch.Size = new Size(334, 89);
            btnaccountsearch.TabIndex = 5;
            btnaccountsearch.Text = "Account Search";
            btnaccountsearch.UseVisualStyleBackColor = false;
            btnaccountsearch.Click += btnaccountsearch_Click;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = SystemColors.GradientActiveCaption;
            btnPayment.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnPayment.Location = new Point(0, 679);
            btnPayment.Margin = new Padding(0, 0, 0, 8);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(334, 89);
            btnPayment.TabIndex = 6;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnPaymentHistory
            // 
            btnPaymentHistory.BackColor = SystemColors.GradientActiveCaption;
            btnPaymentHistory.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnPaymentHistory.Location = new Point(0, 776);
            btnPaymentHistory.Margin = new Padding(0, 0, 0, 8);
            btnPaymentHistory.Name = "btnPaymentHistory";
            btnPaymentHistory.Size = new Size(334, 89);
            btnPaymentHistory.TabIndex = 7;
            btnPaymentHistory.Text = "Payment History";
            btnPaymentHistory.UseVisualStyleBackColor = false;
            btnPaymentHistory.Click += btnPaymentHistory_Click;
            // 
            // btnreports
            // 
            btnreports.BackColor = SystemColors.GradientActiveCaption;
            btnreports.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnreports.Location = new Point(0, 873);
            btnreports.Margin = new Padding(0, 0, 0, 8);
            btnreports.Name = "btnreports";
            btnreports.Size = new Size(334, 89);
            btnreports.TabIndex = 8;
            btnreports.Text = "Report";
            btnreports.UseVisualStyleBackColor = false;
            btnreports.Click += btnreports_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Red;
            btnLogOut.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnLogOut.ForeColor = SystemColors.ButtonFace;
            btnLogOut.Location = new Point(0, 970);
            btnLogOut.Margin = new Padding(0, 0, 0, 8);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(334, 89);
            btnLogOut.TabIndex = 10;
            btnLogOut.Text = "Logout";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // mainpanel
            // 
            mainpanel.BackColor = SystemColors.GradientActiveCaption;
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(340, 0);
            mainpanel.Margin = new Padding(3, 4, 3, 4);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1580, 1080);
            mainpanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(mainpanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainpanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDashboard;
        private Button btnUsers;
        private Button btnSections;
        private Button btnStudent;
        private Button btnEnrollment;
        private Button btnAssement;
        private Button btnaccountsearch;
        private Button btnPayment;
        private Button btnPaymentHistory;
        private Button btnreports;
        private Button btnLogOut;
    }
}