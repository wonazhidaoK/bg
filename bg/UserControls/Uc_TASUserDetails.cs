using CommonHelp;
using CommonHelp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace bg.UserControls
{
    public partial class Uc_TASUserDetails : UserControl
    {
        readonly DataHelp help = new DataHelp();
        public Uc_TASUserDetails()
        {
            InitializeComponent();
        }

        private void Uc_UpdateDetails_Load(object sender, EventArgs e)
        {
            btnsaveupdate.Location = new Point(btnsaveupdate.Location.X, btnsaveupdate.Location.Y - 78); 
            BindingTitles();

            BindingTypes();

            BindingCCentre();

            BindingRole();

            BindingDepts();

            BindingdgvU();
        }

        private void BindingdgvU()
        {
            var list = help.GetTAS_UserAll();
            if (txtQS.Text.Trim()!=null)
            {
                list= list.Where(x=>x.Lname.Contains(txtQS.Text.Trim())||x.Fname.Contains(txtQS.Text.Trim())).ToList();
            }
            tASUserBindingSource.DataSource = list;
            dgvU.DataSource = tASUserBindingSource;
        }

        private void BindingDepts()
        {
            List<Dept> depts = new List<Dept>
            {
            Dept.ITGY,
            Dept.MGAF
            };
            deptBindingSource.DataSource = depts;
            cbDept.DataSource = deptBindingSource;
        }

        private void BindingRole()
        {
            List<Role> roles = new List<Role>
            {
            Role.CADM,
            Role.CDSR
            };
            roleBindingSource.DataSource = roles;
            cbRole.DataSource = roleBindingSource;
        }

        private void BindingCCentre()
        {
            List<Cost_Centre> cost_Centres = new List<Cost_Centre>
            {
                Cost_Centre.HQ,
                Cost_Centre.ITGY,
                Cost_Centre.MSAF,
                Cost_Centre.SMG,
                Cost_Centre.UNITA,
                Cost_Centre.UNITB,
                Cost_Centre.UNITC
            };
            costCentreBindingSource.DataSource = cost_Centres;
            cbCCentre.DataSource = costCentreBindingSource;
        }

        private void BindingTypes()
        {
            List<Teacher_type> teacher_Types = new List<Teacher_type>
            {
                Teacher_type.C,
                Teacher_type.T
            };
            teachertypeBindingSource.DataSource = teacher_Types;
            cbType.DataSource = teachertypeBindingSource;
        }

        private void BindingTitles()
        {
            List<Title> titles = new List<Title>()
            {
                Title.Dr,
                Title.EG,
                Title.Ir,
                Title.JP,
                Title.Mr,
                Title.Mrs,
                Title.Ms
            };
            titleBindingSource.DataSource = titles;
            cbTitle.DataSource = titleBindingSource;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (updateForm uf = new updateForm())
            {
                uf.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbType.SelectedIndex)
            {
                case 0:  // ..... some code here...
                    btnsaveupdate.Location = new Point(btnsaveupdate.Location.X, btnsaveupdate.Location.Y - 78);
                    gb1.Visible = false;
                    break;
                case 1:  // ..... some code here...
                    btnsaveupdate.Location = new Point(btnsaveupdate.Location.X, btnsaveupdate.Location.Y + 78);
                    gb1.Visible = true;
                    break;

            }
        }

        private void btnsaveupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSName.Text))
            {
                MessageBox.Show("SName IsNull");
                return;
            }
            if (string.IsNullOrEmpty(tbFname.Text))
            {
                MessageBox.Show("Fname IsNull");
                return;
            }
            if (string.IsNullOrEmpty(tbLname.Text))
            {
                MessageBox.Show("Lname IsNull");
                return;
            }
            if (cbType.SelectedIndex == 1)
            {
                if (string.IsNullOrEmpty(tbSNo.Text))
                {
                    MessageBox.Show("SNo IsNull");
                    return;
                }
                int r = help.AddTAS_Staff(new TAS_Staff
                {
                    CostCentre = cbCCentre.Text.Trim(),
                    Dept = cbDept.Text.Trim(),
                    No = tbSNo.Text.Trim(),
                    Role = cbRole.Text.Trim()
                });
                if (r < 1)
                {
                    MessageBox.Show("Staff 添加失败");
                    return;
                }
            }
            int r2 = help.AddTAS_users(new TAS_User
            {
                Fname = tbFname.Text.Trim(),
                Lname = tbLname.Text.Trim(),
                StaffNo = tbSNo.Text.Trim(),
                Title = cbTitle.Text.Trim(),
                Type = cbType.Text.Trim(),
                UId = tbSName.Text.Trim(),
            });
            if (r2 < 1)
            {
                MessageBox.Show("users 添加失败");
                return;
            }
            else { MessageBox.Show("users 添加成功"); BindingdgvU(); }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindingdgvU();
        }
    }
}
