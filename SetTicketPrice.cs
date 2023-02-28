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
    public partial class SetTicketPrice : Form
    {
        XmlSerializer xmlSerializer;
        List<TicketPrice> ticketPrices;

        public SetTicketPrice()
        {
            InitializeComponent();
            ticketPrices = new List<TicketPrice>();
            xmlSerializer = new XmlSerializer(typeof(List<TicketPrice>));
            abc();
        }

        private void setPrice_btn_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(path.pathB, FileMode.OpenOrCreate, FileAccess.Write);
            
            Random r = new Random();

            TicketPrice T = new TicketPrice();

            if (day_comboBox1.SelectedIndex == 0)
            {

                if (radioC_btn.Checked || radioA_btn.Checked)
                {
                    T.dayType = day_comboBox1.SelectedItem.ToString();

                    if (radioC_btn.Checked)
                    {
                        if (ticketPrices.Count > 0)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Weekday" && (t.age >= 5 && t.age <= 12))
                                {
                                    Console.WriteLine("Already Exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }
                       
                        T.age = r.Next(5, 11);
                    }
                    else
                    {
                        if(ticketPrices.Count > 0)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Weekday" && (t.age >= 13 && t.age <= 60))
                                {
                                    Console.WriteLine("already exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }
                        
                        T.age = r.Next(12, 60);
                    }

                    T.group = 0;

                    T.oneHour = Int32.Parse(price1hr.Text);
                    T.twoHour = Int32.Parse(price2hrs.Text);
                    T.threeHour = Int32.Parse(price3hrs.Text);
                    T.fourHour = Int32.Parse(price4hrs.Text);
                    T.wholeday = Int32.Parse(priceWholeDay.Text);

                    Console.WriteLine("Radio button weekday");
                    Console.WriteLine(T.dayType);
                }

                if(comboBox2.SelectedIndex >= 0)
                {
                    if(ticketPrices.Count > 0) {
                        if (comboBox2.SelectedIndex == 0)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Weekday" && t.group == 5)
                                {
                                    Console.WriteLine("already exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }


                        if (comboBox2.SelectedIndex == 1)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Weekday" && t.group == 10)
                                {
                                    Console.WriteLine("already exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }

                        if (comboBox2.SelectedIndex == 2)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Weekday" && t.group == 15)
                                {
                                    Console.WriteLine("already exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }

                        if (comboBox2.SelectedIndex == 3)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Weekday" && t.group == 20)
                                {
                                    Console.WriteLine("already exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }
                    }
                    
                    T.dayType = day_comboBox1.SelectedItem.ToString();

                    T.age = 0;

                    T.group = Int32.Parse(comboBox2.SelectedItem.ToString());

                    T.oneHour = Int32.Parse(price1hr.Text);
                    T.twoHour = Int32.Parse(price2hrs.Text);
                    T.threeHour = Int32.Parse(price3hrs.Text);
                    T.fourHour = Int32.Parse(price4hrs.Text);
                    T.wholeday = Int32.Parse(priceWholeDay.Text);

                    Console.WriteLine("combobox weekday");
                    Console.WriteLine(T.dayType);

                }

            }
            else
            {
                if (radioC_btn.Checked || radioA_btn.Checked)
                {
                    T.dayType = day_comboBox1.SelectedItem.ToString();

                    if (radioC_btn.Checked)
                    {
                        if(ticketPrices.Count > 0)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Holiday" && (t.age >= 5 && t.age <= 12))
                                {
                                    Console.WriteLine("Already Exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }
                        
                        T.age = r.Next(5, 11);
                    }
                    else
                    {
                        if(ticketPrices.Count > 0)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Holiday" && (t.age >= 13 && t.age <= 60))
                                {
                                    Console.WriteLine("already exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }
                        
                        T.age = r.Next(12, 60);
                    }

                    T.group = 0;

                    T.oneHour = Int32.Parse(price1hr.Text);
                    T.twoHour = Int32.Parse(price2hrs.Text);
                    T.threeHour = Int32.Parse(price3hrs.Text);
                    T.fourHour = Int32.Parse(price4hrs.Text);
                    T.wholeday = Int32.Parse(priceWholeDay.Text);

                    Console.WriteLine("Radio button holiday");
                    Console.WriteLine(T.dayType);

                }

                if (comboBox2.SelectedIndex >= 0)
                {
                    if (ticketPrices.Count > 0)
                    {
                        if (comboBox2.SelectedIndex == 0)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Holiday" && t.group == 5)
                                {
                                    Console.WriteLine("already exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }


                        if (comboBox2.SelectedIndex == 1)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Holiday" && t.group == 10)
                                {
                                    Console.WriteLine("already exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }

                        if (comboBox2.SelectedIndex == 2)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Holiday" && t.group == 15)
                                {
                                    Console.WriteLine("already exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }

                        if (comboBox2.SelectedIndex == 3)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Holiday" && t.group == 20)
                                {
                                    Console.WriteLine("already exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }
                        
                    }
                    
                    T.dayType = day_comboBox1.SelectedItem.ToString();

                    T.age = 0;

                    T.group = Int32.Parse(comboBox2.SelectedItem.ToString());

                    T.oneHour = Int32.Parse(price1hr.Text);
                    T.twoHour = Int32.Parse(price2hrs.Text);
                    T.threeHour = Int32.Parse(price3hrs.Text);
                    T.fourHour = Int32.Parse(price4hrs.Text);
                    T.wholeday = Int32.Parse(priceWholeDay.Text);

                    Console.WriteLine("combobox holiday");
                    Console.WriteLine(T.dayType);

                }

            }


            ticketPrices.Add(T);
            xmlSerializer.Serialize(fileStream, ticketPrices);
            fileStream.Close();
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox2.Enabled = false;
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox2.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioC_btn.Enabled = false;
            radioA_btn.Enabled = false;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            radioC_btn.Checked = false;
            radioA_btn.Checked = false;
            comboBox2.SelectedIndex = -1;
            comboBox2.Text = "Group of";
            comboBox2.Enabled = true;
            radioC_btn.Enabled = true;
            radioA_btn.Enabled = true;
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
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }

        private void SetTicketPrice_Load(object sender, EventArgs e)
        {

        }

        private void day_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void price1hr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
