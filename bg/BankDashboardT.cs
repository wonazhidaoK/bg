using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bg
{
    public partial class BankDashboardT : Form
    {
        public BankDashboardT()
        {
            InitializeComponent();
        }

        private void BankDashboardT_Load(object sender, EventArgs e)
        {

        }

        private void panelControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnView);
            UserControls.Uc_TASUserDetailsT uu = new UserControls.Uc_TASUserDetailsT();
            addControls(uu);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void addControls(UserControl uc)
        {
            panelControls.Controls.Clear();
            uc.Dock = DockStyle.Right;
            panelControls.Controls.Add(uc);
            uc.BringToFront();
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnView);
            UserControls.Uc_DutyDetailsT uu = new UserControls.Uc_DutyDetailsT();
            addControls(uu);
        }

        private void btnGenrate_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnView);
            UserControls.Uc_DeptFeeder uu = new UserControls.Uc_DeptFeeder();
            addControls(uu);
        }

        private void btnSee_Click(object sender, EventArgs e)
        { 
            moveSidePanel(btnView);
            UserControls.Uc_CentralFeeder uu = new UserControls.Uc_CentralFeeder();
            addControls(uu);
        }
    }
}
