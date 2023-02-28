using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recreation_Center
{
    public class path
    {
        public static String pathB = System.IO.Path.GetDirectoryName(Application.ExecutablePath).ToString()+ "/ticketPricedetailsx.xml";

        public static String pathC = System.IO.Path.GetDirectoryName(Application.ExecutablePath).ToString() + "/visitorDetailsx.xml";
    }
}
