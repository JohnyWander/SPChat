using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SPChat.Configuration
{
    
    internal static class ConfigManipulator
    {

       public enum Config
        {
            connection,
            peer2peer,
            server

        }

        public static XmlDocument Open_config(Config conf)
        {
            MessageBox.Show(conf.ToString());
            XmlDocument doc = new XmlDocument();
            doc.Load("Config\\"+conf.ToString()+".conf");

            return doc;
        }
        public static bool ConnectionConf_set_ip(string value)
        {
            XmlDocument doc =Open_config(Config.connection);
            doc.GetElementById("IP");
            return true;
        }

       // public static 

    }
}
