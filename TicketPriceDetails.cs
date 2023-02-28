using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;


namespace Recreation_Center
{
    public partial class TicketPriceDetails : Form
    {
        XmlSerializer xmlSerializer;
        List<TicketPrice> ticketPrices;

        public TicketPriceDetails()
        {
            InitializeComponent();
            ticketPrices = new List<TicketPrice>();
            xmlSerializer = new XmlSerializer(typeof(List<TicketPrice>));
            abc();
            ticketPrice.DataSource = ticketPrices;
        }

        private void abc()
        {
            FileStream fileStream = new FileStream(path.pathB, FileMode.Open, FileAccess.Read);
            try
            {
                var v = xmlSerializer.Deserialize(fileStream);

                ticketPrices = (List<TicketPrice>)v;

                fileStream.Close();
            }
            catch (Exception e)
            {
                fileStream.Close();
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Staff a = new Staff();
            a.Show();
            this.Hide();
        }

        private void TicketPriceDetails_Load(object sender, EventArgs e)
        {

        }

        private void ticketPrice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
