using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Recreation_Center
{
    public partial class Login : Form
    {
        private Thread th;

        public Login()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String staff_Username = "manzil";
            String staff_Password = "manzil2055";

            String get_staff_Username = stUser.Text.Trim();
            String get_staff_Password = stPw.Text.Trim();

            if (get_staff_Username != "" || get_staff_Password != "")
            {
                if (staff_Username == get_staff_Username && staff_Password == get_staff_Password)
                {
                    this.Close();
                    th = new Thread(StaffForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please ! input username or password", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure ?", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                stUser.Clear();
                stPw.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String admin_userName = "manzil";
            String admin_password = "manzil2055";

            String get_admin_userName = adUser.Text.Trim();
            String get_admin_password = adPw.Text.Trim();

            if (get_admin_userName != "" || get_admin_password != "")
            {
                if (admin_userName == get_admin_userName && admin_password == get_admin_password)
                {
                    //Admin admin_dashboard = new Admin();
                    //this.Hide();
                    //admin_dashboard.ShowDialog();
                    //this.Close();
                    this.Close();
                    th = new Thread(AdminForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please ! input username or password", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }


        private void AdminForm(Object obj)
        {
            Application.Run(new Admin());

        }
        private void StaffForm(Object obj)
        {
            Application.Run(new Staff());

        }


        private void adCan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure ?", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                adUser.Clear();
                adPw.Clear();
            }
        }

        private void checkBox_adShowPw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_adShowPw.Checked)
            {
                adPw.UseSystemPasswordChar = false;
            }
            else
            {
                adPw.UseSystemPasswordChar = true;
            }
        }

        private void adUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_stShowPw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_stShowPw.Checked)
            {
                stPw.UseSystemPasswordChar = false;
            }
            else
            {
                stPw.UseSystemPasswordChar = true;
            }
        }

        private void stPw_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
