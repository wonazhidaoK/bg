using CommonHelp;
using System;
using System.Linq;
using System.Windows.Forms;

namespace bg.UserControls
{
    public partial class Uc_TASUserDetailsT : UserControl
    {
        readonly DataHelp help = new DataHelp();
        public Uc_TASUserDetailsT()
        {
            InitializeComponent();
        }

        private void Uc_UpdateDetails_Load(object sender, EventArgs e)
        {
            BindingdgvU();
        }

        private void BindingdgvU()
        {
            var list = help.GetTAS_UserAll();
            if (txtQS.Text.Trim() != null)
            {
                list = list.Where(x => x.Lname.Contains(txtQS.Text.Trim()) || x.Fname.Contains(txtQS.Text.Trim())).ToList();
            }
            tASUserBindingSource.DataSource = list;
            dgvU.DataSource = tASUserBindingSource;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (updateForm uf = new updateForm())
            {
                uf.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindingdgvU();
        }
    }
}
