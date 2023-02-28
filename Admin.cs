using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recreation_Center
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void setTicketBtn_Click(object sender, EventArgs e)
        {
            SetTicketPrice f = new SetTicketPrice();
            f.Show();
            this.Hide();
        }

        private void daily_weeklyRep_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Console.WriteLine(System.IO.Path.GetDirectoryName(Application.ExecutablePath));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Hide();
        }
    }
}
