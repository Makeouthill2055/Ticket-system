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
    public partial class Visitor_Details : Form
    {
        XmlSerializer xmlSerializer2;
        List<VistorDetails> vistorDetails;

        public Visitor_Details()
        {
            InitializeComponent();
            vistorDetails = new List<VistorDetails>();
            xmlSerializer2 = new XmlSerializer(typeof(List<VistorDetails>));
            abc();
            if(vistorDetails.Count > 0)
            {
                visitorDetailsGrid.DataSource = vistorDetails;
            }
            else
            {
                visitorDetailsGrid.DataSource = vistorDetails;
                Console.WriteLine("No visitor Entered Till date");
            }
        }

        private void abc()
        {
            FileStream fileStream = new FileStream(path.pathC, FileMode.Open, FileAccess.Read);
            try
            {
                var v = xmlSerializer2.Deserialize(fileStream);

                vistorDetails = (List<VistorDetails>)v;

                Console.WriteLine(vistorDetails);
                fileStream.Close();
            }
            catch (Exception e)
            {
                fileStream.Close();
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Staff sa = new Staff();
            sa.Show();
            this.Hide();
        }

        private void Visitor_Details_Load(object sender, EventArgs e)
        {

        }
    }
}
