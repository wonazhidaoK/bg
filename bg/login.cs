using CommonHelp;
using CommonHelp.Models;
using System;
using System.Windows.Forms;

namespace bg
{
    public partial class login : Form
    {
        readonly DataHelp help = new DataHelp();
        public login()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            System_User login = new System_User
            {
                UserName = txtuser.Text,
                Password = txtpass.Text
            };
            var users = help.GetUsers(login);
            string ezbItemValue = comboBox1.SelectedItem.ToString();
            if (users.Count > 0)
            {
                foreach (var item in users)
                {
                    if (item.UserType.Trim() == ezbItemValue)
                    {
                        MessageBox.Show("You are login as " + item.UserName);
                        if (comboBox1.SelectedIndex == 0)
                        {
                            BankDashboard f = new BankDashboard();
                            f.Show();
                            Hide();
                        }
                        else
                        {
                            BankDashboardT ff = new BankDashboardT();
                            ff.Show();
                            Hide();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
