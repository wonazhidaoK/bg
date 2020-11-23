using SLRDbConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bg
{
    public partial class updateForm : Form
    {
        DbConnector db;
        public updateForm()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void updateForm_Load(object sender, EventArgs e)
        {
            //db.FillCombobox("select Name from tas_user", cmbTypes);
        }

        private void btnsaveupdate_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                insertValuse();
            }
        }

        private void insertValuse()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to add this work?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                db.performCRUD("insert into TAS_user (role,user_title,staff_no,user_fname,user_lname,staff_short_name,dept,teacher_type) Values('" + txtRole.Text+ "','" + txtTittle.Text + "','" + txtFname.Text + "','" + txtLname.Text + "','" + txtSname.Text + "','" + txtDept.Text + "','" + txtType.Text + "')");
                MessageBox.Show("Work Added Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        private bool isFormValid()
        {
            if (txtRole.Text.Trim() == string.Empty 
                || txtNo.Text.Trim() == string.Empty 
                || txtFname.Text.Trim() == string.Empty 
                || txtLname.Text.Trim() == string.Empty 
                || txtSname.Text.Trim() == string.Empty 
                || txtTittle.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill All Required Fields", "Required Fields are Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtDept_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
