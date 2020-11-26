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
            deptBindingSource.DataSource = Dept.GetAll();
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!this.dgvU.Rows[this.rowIndex].IsNewRow) //判断当前行是否为空行
            {
               
             var uid=   this.dgvU.Rows[this.rowIndex].Cells[1].Value;
              var classs=  help.GetTAS_ClassesRecordAll().Where(x => x.UId.Equals(uid)).ToList();
                if (classs.Count > 0)
                {
                    MessageBox.Show("当前教师存在课程，不能删除!");
                }
                else 
                {
                    var id = this.dgvU.Rows[this.rowIndex].Cells[0].Value;
                   int r= help.DelectTAS_users(new TAS_User { ID =Convert.ToInt32( id.ToString()) });
                    this.dgvU.Rows.RemoveAt(rowIndex);
                }
            }
        }

        private int rowIndex = 0;//定义一个全局变量，以便删除行方法可以访问的到

        private void dgvU_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)//判断是否当前弹起的右键
            {
                rowIndex = e.RowIndex;
                this.dgvU.Rows[e.RowIndex].Selected = true;//选中鼠标所在的当前行
                this.dgvU.CurrentCell = this.dgvU.Rows[e.RowIndex].Cells[1];//默认当前单元格为第一行第一个
                //this.contextMenuStrip1.Show(this.dataGridView1, e.Location);//右键菜单绑定当前位置，也就是第一行第一个
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
    }
}
