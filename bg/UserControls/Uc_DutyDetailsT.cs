using CommonHelp;
using CommonHelp.Models;
using System;
using System.Windows.Forms;

namespace bg.UserControls
{
    public partial class Uc_DutyDetailsT : UserControl
    {
        readonly DataHelp help = new DataHelp();
        public Uc_DutyDetailsT()
        {
            InitializeComponent();
        }

      

        private void UcDutyDetails_Load(object sender, EventArgs e)
        { 
            BindingDuty();
        }
        

        private void BindingDuty()
        {
            tASDutyBindingSource.DataSource = help.GetTAS_DutysAll();
            dgvDuty.DataSource = tASDutyBindingSource;
        }

        
    }
}
