using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace Recreation_Center
{
    public partial class BillingTicket : Form
    {
        XmlSerializer xmlSerializer;
        List<TicketPrice> ticketPrices;

        XmlSerializer xmlSerializer2;
        List<VistorDetails> vistorDetails;

        int count = 0;

        public BillingTicket()
        {
            InitializeComponent();
            xmlSerializer = new XmlSerializer(typeof(List<TicketPrice>));
            ticketPrices = new List<TicketPrice>();

            vistorDetails = new List<VistorDetails>();
            xmlSerializer2 = new XmlSerializer(typeof(List<VistorDetails>));
            abc();

        }

        private void age_resetBtn_Click(object sender, EventArgs e)
        {
            child_radioButton.Checked = false;
            adult_radioButton.Checked = false;
            groupBox.SelectedIndex = -1;
            groupBox.Text = "Group of";
            groupBox.Enabled = true;
            child_radioButton.Enabled = true;
            adult_radioButton.Enabled = true;
            durationHrs.SelectedIndex = -1;
            durationHrs.Text = "Hours";
            durationHrs.Enabled = false;
            checkoutTime_box.Text = "";
            TotalPrice.Text = "";

        }

        private void BillingTicket_Load(object sender, EventArgs e)
        {
            /*Random rnd = new Random();
            int num = rnd.Next(1, 1000);
*/
            foreach (VistorDetails vis in vistorDetails)
            {
                count += 1;
            }

            count += 1; 
            timer1.Start();
            /*textBox1.Text = num.ToString();*/
            idBox.Text = (count).ToString();
            dateBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dayBox.Text = DateTime.Today.DayOfWeek.ToString();
            timeBox.Text = DateTime.Now.ToLongTimeString();
            durationHrs.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeBox.Text = DateTime.Now.ToLongTimeString();

            DateTime date = DateTime.Parse(timeBox.Text, System.Globalization.CultureInfo.CurrentCulture);

            if (durationHrs.Text == "1")
            {
                checkoutTime_box.Text = date.AddHours(1).ToLongTimeString();
            }

            if (durationHrs.Text == "2")
            {
                checkoutTime_box.Text = date.AddHours(2).ToLongTimeString();
            }

            if (durationHrs.Text == "3")
            {
                checkoutTime_box.Text = date.AddHours(3).ToLongTimeString();
            }

            if (durationHrs.Text == "4")
            {
                checkoutTime_box.Text = date.AddHours(4).ToLongTimeString();
            }

            if (durationHrs.Text == "Whole Day")
            {
                checkoutTime_box.Text = AbsoluteEnd(date).ToLongTimeString();
            }

            timer1.Start();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Start();

            FileStream fileStream = new FileStream(path.pathB, FileMode.Open, FileAccess.Read);

            var priceData = xmlSerializer.Deserialize(fileStream);

            ticketPrices = (List<TicketPrice>)priceData;

            DateTime date = DateTime.Parse(timeBox.Text, System.Globalization.CultureInfo.CurrentCulture);


            /*One Hours*/
            if (durationHrs.Text == "1")
            {
                checkoutTime_box.Text = date.AddHours(1).ToLongTimeString();

                if (child_radioButton.Checked || adult_radioButton.Checked)
                {
                    if (child_radioButton.Checked)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if(price.age >=5 && price.age <= 12)
                            {
                                if(dayBox.Text.Equals("Saturday"))
                                {
                                    Console.WriteLine(price.age);

                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.oneHour.ToString();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(price.age);
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.oneHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                    if (adult_radioButton.Checked)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.age >= 13 && price.age <= 60)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.oneHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.oneHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                    return;
                }

                if (groupBox.SelectedIndex >= 0)
                {
                    if(groupBox.SelectedIndex == 0)
                    {
                        Console.WriteLine("hour of 1");
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 5)
                            {
                                Console.WriteLine("group of 5");
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.oneHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.oneHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (groupBox.SelectedIndex == 1)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 10)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.oneHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.oneHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (groupBox.SelectedIndex == 2)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 15)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.oneHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.oneHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (groupBox.SelectedIndex == 3)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 20)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.oneHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.oneHour.ToString();
                                    }
                                }

                            }
                        }
                    }



                }
            }


            /*Two Hours*/
            if (durationHrs.Text == "2")
            {
                checkoutTime_box.Text = date.AddHours(2).ToLongTimeString();

                if (child_radioButton.Checked || adult_radioButton.Checked)
                {
                    if (child_radioButton.Checked)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.age >= 5 && price.age <= 12)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    Console.WriteLine(price.age);

                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.twoHour.ToString();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(price.age);
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.twoHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                    if (adult_radioButton.Checked)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.age >= 13 && price.age <= 60)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.twoHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.twoHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                    return;
                }

                if (groupBox.SelectedIndex >= 0)
                {
                    if (groupBox.SelectedIndex == 0)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 5)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.twoHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.twoHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (groupBox.SelectedIndex == 1)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 10)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.twoHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.twoHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (groupBox.SelectedIndex == 2)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 15)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.twoHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.twoHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (groupBox.SelectedIndex == 3)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 20)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.twoHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.twoHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                }
            }

            /*Three Hours*/
            if (durationHrs.Text == "3")
            {
                checkoutTime_box.Text = date.AddHours(3).ToLongTimeString();

                if (child_radioButton.Checked || adult_radioButton.Checked)
                {
                    if (child_radioButton.Checked)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.age >= 5 && price.age <= 12)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    Console.WriteLine(price.age);

                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.threeHour.ToString();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(price.age);
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.threeHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                    if (adult_radioButton.Checked)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.age >= 13 && price.age <= 60)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.threeHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.threeHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                    return;
                }

                if (groupBox.SelectedIndex >= 0)
                {
                    if (groupBox.SelectedIndex == 0)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 5)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.threeHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.threeHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (groupBox.SelectedIndex == 1)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 10)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.threeHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.threeHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (groupBox.SelectedIndex == 2)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 15)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.threeHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.threeHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (groupBox.SelectedIndex == 3)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 20)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.threeHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.threeHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                }
            }

            /*four Hours*/
            if (durationHrs.Text == "4")
            {
                checkoutTime_box.Text = date.AddHours(4).ToLongTimeString();

                if (child_radioButton.Checked || adult_radioButton.Checked)
                {
                    if (child_radioButton.Checked)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.age >= 5 && price.age <= 12)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    Console.WriteLine(price.age);

                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.fourHour.ToString();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(price.age);
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.fourHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                    if (adult_radioButton.Checked)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.age >= 13 && price.age <= 60)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.fourHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.fourHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                    return;
                }

                if (groupBox.SelectedIndex >= 0)
                {
                    if (groupBox.SelectedIndex == 0)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 5)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.fourHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.fourHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (groupBox.SelectedIndex == 1)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 10)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.fourHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.fourHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (groupBox.SelectedIndex == 2)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 15)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.fourHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.fourHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (groupBox.SelectedIndex == 3)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 20)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.fourHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.fourHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                }
            }

            /*whole day*/
            if (durationHrs.Text == "Whole Day")
            {
                checkoutTime_box.Text = AbsoluteEnd(date).ToLongTimeString();

                if (child_radioButton.Checked || adult_radioButton.Checked)
                {
                    if (child_radioButton.Checked)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.age >= 5 && price.age <= 12)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.wholeday.ToString();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(price.age);
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.wholeday.ToString();
                                    }
                                }

                            }
                        }
                    }
                    if (adult_radioButton.Checked)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.age >= 13 && price.age <= 60)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.wholeday.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.wholeday.ToString();
                                    }
                                }

                            }
                        }
                    }
                    return;
                }

                if (groupBox.SelectedIndex >= 0)
                {
                    if (groupBox.SelectedIndex == 0)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 5)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.wholeday.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.wholeday.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (groupBox.SelectedIndex == 1)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 10)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.wholeday.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.wholeday.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (groupBox.SelectedIndex == 2)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 15)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.wholeday.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.wholeday.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (groupBox.SelectedIndex == 3)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 20)
                            {
                                if (dayBox.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        TotalPrice.Text = price.wholeday.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        TotalPrice.Text = price.wholeday.ToString();
                                    }
                                }

                            }
                        }
                    }
                }
            }
        }


        public static DateTime AbsoluteStart(DateTime dateTime)
        {
            return dateTime.Date;
        }

        public static DateTime AbsoluteEnd(DateTime dateTime)
        {
            return AbsoluteStart(dateTime).AddDays(1).AddTicks(-1);
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            groupBox.Enabled = false;
            durationHrs.Enabled = true;
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            groupBox.Enabled = false;
            durationHrs.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            child_radioButton.Enabled = false;
            adult_radioButton.Enabled = false;
            durationHrs.Enabled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            TimeSpan start = TimeSpan.Parse("10:00"); //10am o'clock
            TimeSpan end = TimeSpan.Parse("18:00");  //6pm o'clock
            TimeSpan now = DateTime.Now.TimeOfDay;

            if ((now > start) && (now < end))
            {
                FileStream fileStream2 = new FileStream(path.pathC, FileMode.OpenOrCreate, FileAccess.Write);

                VistorDetails v = new VistorDetails();

                v.id = Int32.Parse(idBox.Text);
                v.name = nameBox.Text;
                v.contact = contactBox.Text;
                v.date = DateTime.Parse(dateBox.Text, System.Globalization.CultureInfo.CurrentCulture);
                /*v.date = Convert.ToDateTime(textBox4.Text);*/
                String todayDay = dayBox.Text;

                switch (todayDay)
                {
                    case "Sunday":
                        v.day = DayOfWeek.Sunday;
                        break;
                    case "Monday":
                        v.day = DayOfWeek.Monday;
                        break;
                    case "Tuesday":
                        v.day = DayOfWeek.Tuesday;
                        break;
                    case "Wednesday":
                        v.day = DayOfWeek.Wednesday;
                        break;
                    case "Thursday":
                        v.day = DayOfWeek.Thursday;
                        break;
                    case "Friday":
                        v.day = DayOfWeek.Friday;
                        break;
                    default:
                        v.day = DayOfWeek.Saturday;
                        break;
                }

                v.CheckInTime = DateTime.Parse(timeBox.Text, System.Globalization.CultureInfo.CurrentCulture);

                Random r = new Random();

                if ((!child_radioButton.Checked && !adult_radioButton.Checked) && (groupBox.SelectedItem == null))
                {
                    MessageBox.Show("Please select either Age or Group", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (child_radioButton.Checked)
                    {
                        v.age = r.Next(5, 11);
                    }
                    else if (adult_radioButton.Checked)
                    {
                        v.age = r.Next(12, 60);
                    }
                    else
                    {
                        v.age = 0;
                    }

                    if (groupBox.SelectedItem == null)
                    {
                        v.group = 0;
                    }
                    else
                    {
                        v.group = Int32.Parse(groupBox.Text);
                    }
                }

                if (durationHrs.SelectedItem == null)
                {
                    MessageBox.Show("Please select duration hours", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (groupBox.Text == "1" || groupBox.Text == "2" || groupBox.Text == "3" || groupBox.Text == "4")
                    {
                        v.Duration = Int32.Parse(durationHrs.Text);
                    }
                    else
                    {
                        v.Duration = 8;
                    }
                }

                v.CheckoutTime = DateTime.Parse(checkoutTime_box.Text, System.Globalization.CultureInfo.CurrentCulture);

                v.TotalPrice = Int32.Parse(TotalPrice.Text);


                vistorDetails.Add(v);
                xmlSerializer2.Serialize(fileStream2, vistorDetails);
                fileStream2.Close();

                Console.WriteLine(v.id);
                Console.WriteLine(v.name);
                Console.WriteLine(v.contact);
                Console.WriteLine(v.date);
                Console.WriteLine(v.day);
                Console.WriteLine(v.CheckInTime);
                Console.WriteLine(v.age);
                Console.WriteLine(v.group);
                Console.WriteLine(v.Duration);
                Console.WriteLine(v.CheckoutTime);
                Console.WriteLine(v.TotalPrice);

                idBox.Text = "";
                nameBox.Text = "";
                contactBox.Text = "";
                checkoutTime_box.Text = "";
                TotalPrice.Text = "";

                groupBox.SelectedIndex = -1;
                groupBox.Text = "Group of";

                child_radioButton.Checked = false;
                adult_radioButton.Checked = false;

                durationHrs.SelectedIndex = -1;
                durationHrs.Text = "Hours";

                groupBox.Enabled = true;
                child_radioButton.Enabled = true;
                adult_radioButton.Enabled = true;
                durationHrs.Enabled = false;

                count += 1;
                idBox.Text = count.ToString();

                /*Random rnd = new Random();
                int num = rnd.Next(1, 1000);
                textBox1.Text = num.ToString();*/
            }
            else
            {
                Console.WriteLine("Recreation centre is closed, It's opening time is 10am to 6pm");
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
            catch(Exception e)
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

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}