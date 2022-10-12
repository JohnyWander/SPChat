using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPChat.Common
{
    internal static  class Methods
    {

        public static string DateLog()
        {
            StringBuilder datelog = new StringBuilder();
            DateTime now = DateTime.Now;

            string Hour;
            string Minute;
            string Second;

            if (now.Hour < 10)
            { Hour = "0" + Convert.ToString(now.Hour); }
            else { Hour = Convert.ToString(now.Hour); }

            if (now.Minute < 10)
            { Minute = 0 + Convert.ToString(now.Minute); }
            else { Minute = Convert.ToString(now.Minute); }

            if (now.Second < 10)
            { Second = 0 + Convert.ToString(now.Second); }
            else { Second = Convert.ToString(now.Second); }


         

            datelog.Append('[');
            datelog.Append(Hour);
            datelog.Append(':');
            datelog.Append(Minute);
            datelog.Append(':');
            datelog.Append(Second);
            datelog.Append(']');

            return datelog.ToString();




        }


    }
}
