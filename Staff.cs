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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void ticketDetailsBtn_Click_1(object sender, EventArgs e)
        {
            TicketPriceDetails tpd = new TicketPriceDetails();
            tpd.Show();
            this.Hide();
        }

        private void VisitorDetailsBtn_Click_1(object sender, EventArgs e)
        {
            BillingTicket billingTicket = new BillingTicket();
            billingTicket.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Visitor_Details vd = new Visitor_Details();
            vd.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login a = new Login ();
            a.Show();
            this.Hide();
        }
    }
}
