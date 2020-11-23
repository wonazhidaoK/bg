using CommonHelp;
using CommonHelp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bg.UserControls
{
    public partial class Uc_CourseRecordDetails : UserControl
    {
        readonly DataHelp help = new DataHelp();
        public Uc_CourseRecordDetails()
        {
            InitializeComponent();
        }

        private void Uc_UpdateDetails_Load(object sender, EventArgs e)
        {
            //BindingCourseTypes();
            BindingDepts();
            BindingUsers();

            tASCourseRecordBindingSource.DataSource = help.GetTAS_CourseRecordAll();
            dgCR.DataSource = tASCourseRecordBindingSource;
        }

        #region binding
        private void BindingUsers()
        {
            tASUserBindingSource.DataSource = help.GetTAS_UserAll(); ;
            cbUid.DataSource = tASUserBindingSource;
        }
        //private void BindingCourseTypes()
        //{
        //    List<CourseType> courseTypes = new List<CourseType>()
        //    {
        //       CourseType.L,
        //       CourseType.T
        //    };
        //    courseTypeBindingSource.DataSource = courseTypes;
        //    cbType.DataSource = courseTypeBindingSource;
        //}
        private void BindingDepts()
        {
            List<Dept> depts = new List<Dept>()
            {
              Dept.ITGY,
              Dept.MGAF
            };

            deptBindingSource.DataSource = depts;
            cbDept.DataSource = deptBindingSource;
        }
        #endregion


        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (updateForm uf = new updateForm())
            {
                uf.ShowDialog();
                this.OnLoad(e);
            }
        }




        private void btnsaveupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCCode.Text))
            {
                MessageBox.Show("SName IsNull");
                return;
            }
            if (string.IsNullOrEmpty(tbCTitle.Text))
            {
                MessageBox.Show("Fname IsNull");
                return;
            }
            //if (string.IsNullOrEmpty(tbHours.Text))
            //{
            //    MessageBox.Show("Hours IsNull");
            //    return;
            //}

            int r2 = help.AddTAS_CourseRecords(new TAS_CourseRecord
            {
                CourseCode = tbCCode.Text,
                //Type = cbType.Text,
                //UId = tbCCode.Text,
                CourseTitle = tbCTitle.Text,
                Dept = cbDept.Text,
                HQ = string.IsNullOrEmpty(tbHQ.Text) ? 0 : Convert.ToInt32(tbHQ.Text),
                //Hours = string.IsNullOrEmpty(tbHours.Text) ? 0 : Convert.ToInt32(tbHQ.Text),
                ITGY = string.IsNullOrEmpty(tbITGY.Text) ? 0 : Convert.ToInt32(tbHQ.Text),
                MSAF = string.IsNullOrEmpty(tbMSAF.Text) ? 0 : Convert.ToInt32(tbHQ.Text),
                SMG = string.IsNullOrEmpty(tbMSAF.Text) ? 0 : Convert.ToInt32(tbHQ.Text),
                UNITA = string.IsNullOrEmpty(tbUNITA.Text) ? 0 : Convert.ToInt32(tbHQ.Text),
                UNITB = string.IsNullOrEmpty(tbUNITB.Text) ? 0 : Convert.ToInt32(tbHQ.Text),
                UNITC = string.IsNullOrEmpty(tbUNITC.Text) ? 0 : Convert.ToInt32(tbHQ.Text),
                Schooltime = dtp1.Value

            });
            if (r2 < 1)
            {
                MessageBox.Show("users 添加失败");
                return;
            }
            else { MessageBox.Show("users 添加成功"); }
        }

        //通用方法
        /// <summary>
        /// 判断文本框输入内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">KeyPressEventArgs对象</param>
        private void CheckNumber(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
            //小数点的处理。
            if ((int)e.KeyChar == 46) //小数点                          
            {
                if (((TextBox)sender).Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(((TextBox)sender).Text, out oldf);
                    b2 = float.TryParse(((TextBox)sender).Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }

        private void tbHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckNumber(sender, e);
        }

        private void tbHQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckNumber(sender, e);
        }

        private void tbUNITA_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckNumber(sender, e);
        }

        private void tbUNITB_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckNumber(sender, e);
        }

        private void tbUNITC_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckNumber(sender, e);
        }

        private void tbITGY_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckNumber(sender, e);
        }

        private void tbMSAF_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckNumber(sender, e);
        }

        private void tbSMG_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckNumber(sender, e);
        }
    }
}
