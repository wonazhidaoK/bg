using CommonHelp;
using CommonHelp.Models;
using System;
using System.Windows.Forms;

namespace bg.UserControls
{
    public partial class Uc_DutyDetails : UserControl
    {
        readonly DataHelp help = new DataHelp();
        public Uc_DutyDetails()
        {
            InitializeComponent();
        }

        private void btnsaveupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbHours.Text))
            {
                MessageBox.Show("Hours IsNull");
                return;
            }
            int r2 = help.AddTAS_Dutys(new TAS_Duty
            {

                Hours = string.IsNullOrEmpty(tbHours.Text) ? 0 : Convert.ToInt32(tbHours.Text),
                CostCentre = cbCostCentre.Text,
                Duty = tbDuty.Text,
                StaffNo = cbStaffNo.Text

            });
            if (r2 < 1)
            {
                MessageBox.Show("Duty 添加失败");
                return;
            }
            else { MessageBox.Show("Duty 添加成功"); }
            BindingDuty();
        }

        private void UcDutyDetails_Load(object sender, EventArgs e)
        {
            BindingCCentre();
            BindingStaffNo();
            BindingDuty();
        }

        private void BindingCCentre()
        {
            costCentreBindingSource.DataSource = Cost_Centre.GetAll();
            cbCostCentre.DataSource = costCentreBindingSource;
        }

        private void BindingStaffNo()
        {
            tASStaffBindingSource.DataSource = help.GetTAS_StaffsAll();
            cbStaffNo.DataSource = tASStaffBindingSource;
        }

        private void BindingDuty()
        {
            tASDutyBindingSource.DataSource = help.GetTAS_DutysAll();
            dgvDuty.DataSource = tASDutyBindingSource;
        }

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
    }
}
