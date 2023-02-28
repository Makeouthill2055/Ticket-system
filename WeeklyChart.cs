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
using System.Windows.Forms.DataVisualization.Charting;

namespace Recreation_Center
{
    public partial class WeeklyChart : Form
    {
        XmlSerializer  xmlSerializer2nd;
        List<VistorDetails> visitorInfo2;

        String TodaysDate = DateTime.Now.ToString("yyyy-MM-dd");
        public WeeklyChart()
        {
            InitializeComponent();
             xmlSerializer2nd = new XmlSerializer(typeof(List<VistorDetails>));
            visitorInfo2 = new List<VistorDetails>();
            weeklyChart(TodaysDate);
        }

        private void weeklyChart(String date)
        {
            FileStream fileStream = new FileStream(path.pathC, FileMode.Open, FileAccess.Read);

            try
            {

                var visitor2 =  xmlSerializer2nd.Deserialize(fileStream);

                visitorInfo2 = (List<VistorDetails>)visitor2;

                DataTable dtable = new DataTable();

                dtable.Columns.Add("Day");
                dtable.Columns.Add("Total Visitor");
                dtable.Columns.Add("Total Earning");

                int indate = ((int)DateTime.Parse(TodaysDate).DayOfWeek);
                String fDate = (DateTime.Parse(TodaysDate).AddDays(-indate)).ToString("yyyy-MM-dd");
                String LDate = (DateTime.Parse(TodaysDate).AddDays((7 - indate))).ToString("yyyy-MM-dd");

                dtable.Rows.Add("Sunday", calender(fDate), totalPrice(fDate));
                dtable.Rows.Add("Monday", calender(DateTime.Parse(fDate).AddDays(1).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(1).ToString("yyyy-MM-dd")));
                dtable.Rows.Add("Tuesday", calender(DateTime.Parse(fDate).AddDays(2).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(2).ToString("yyyy-MM-dd")));
                dtable.Rows.Add("Wednesday", calender(DateTime.Parse(fDate).AddDays(3).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(3).ToString("yyyy-MM-dd")));
                dtable.Rows.Add("Thursday", calender(DateTime.Parse(fDate).AddDays(4).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(4).ToString("yyyy-MM-dd")));
                dtable.Rows.Add("Friday", calender(DateTime.Parse(fDate).AddDays(5).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(5).ToString("yyyy-MM-dd")));
                dtable.Rows.Add("Saturday", calender(LDate), totalPrice(LDate));

                chart1.Series["Series1"].LegendText = "Visitors";
                chart1.Series["Series1"].ChartType = SeriesChartType.Column;
                chart1.Series["Series1"].IsValueShownAsLabel = true;
                chart1.Series["Series1"].XValueMember = "Day";
                chart1.Series["Series1"].YValueMembers = "Total Visitor";
                chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
                chart1.DataSource = dtable;

                chart2.Series["Series1"].LegendText = "Price";
                chart2.Series["Series1"].ChartType = SeriesChartType.Column;
                chart2.Series["Series1"].IsValueShownAsLabel = true;
                chart2.Series["Series1"].XValueMember = "Day";
                chart2.Series["Series1"].YValueMembers = "Total Earning";
                chart2.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                chart2.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
                chart2.DataSource = dtable;

                fileStream.Close();
            }
            catch(Exception e)
            {
                fileStream.Close();
            }


        }

        public int calender(String cal)
        {

            int child = visitorInfo2.Where(a => a.date.ToString("yyyy-MM-dd") == cal && (a.age >= 5 && a.age <= 12)).Count();
            int adult = visitorInfo2.Where(a => a.date.ToString("yyyy-MM-dd") == cal && (a.age >= 13 && a.age <= 60)).Count();
            int group5 = visitorInfo2.Where(a => a.date.ToString("yyyy-MM-dd") == cal && a.group == 5).Count() * 5;
            int group10 = visitorInfo2.Where(a => a.date.ToString("yyyy-MM-dd") == cal && a.group == 10).Count() * 10;
            int group15 = visitorInfo2.Where(a => a.date.ToString("yyyy-MM-dd") == cal && a.group == 15).Count() * 15;
            int group20 = visitorInfo2.Where(a => a.date.ToString("yyyy-MM-dd") == cal && a.group == 20).Count() * 20;

            int sum = child + adult + group5 + group10 + group15 + group20;
            return sum;
        }

        public int totalPrice(String cal)
        {

            int totalprice = visitorInfo2.Where(a => a.date.ToString("yyyy-MM-dd") == cal).Select(a => a.TotalPrice).Sum();

            return totalprice;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.Show();
            this.Hide();
        }

        private void WeeklyChart_Load(object sender, EventArgs e)
        {

        }
    }
}
