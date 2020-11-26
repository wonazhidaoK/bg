using System;
using System.Windows.Forms;

namespace bg
{
    public partial class BankDashboard : Form
    {
        int PanelWidth;
        bool isCollapsed;

        public BankDashboard()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        } 

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void addControls(UserControl uc)
        {
            panelControls.Controls.Clear();
            uc.Dock = DockStyle.Right;
            panelControls.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnView);
            UserControls.Uc_TASUserDetails uu = new UserControls.Uc_TASUserDetails();
            addControls(uu);
        } 

        private void btnGenrate_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnGenrate);//Uc_Seedsheet

            UserControls.Uc_DeptFeeder us = new UserControls.Uc_DeptFeeder();
            addControls(us);
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSee);
            UserControls.Uc_CentralFeeder uc = new UserControls.Uc_CentralFeeder();
            addControls(uc);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width -= 10;
                if (panelLeft.Width <= 62)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSee);
            UserControls.Uc_DutyDetails uc = new UserControls.Uc_DutyDetails();
            addControls(uc);
            
        }
    }
}
