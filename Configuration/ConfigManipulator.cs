using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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

        public enum ConnectionConfPools
        {
            IP,
            Port,
            ClientChatColor,
            LoadChatMembersColors

        }


        public static XmlDocument Open_config(Config conf,out string path)
        {
            MessageBox.Show(conf.ToString());
            XmlDocument doc = new XmlDocument();
            path = "Config\\" + conf.ToString() + ".conf";
            doc.Load(path);
           
            return doc;
        }
       // public static bool ConnectionConf_set_ip(string value)
     //   {
     //       XmlDocument doc =Open_config(Config.connection);
      //      doc.GetElementById("IP");
      //      doc = null;
      //      return true;
      //  }

        public static bool ConnectionConf_ChangeConfig(ConnectionConfPools item,string value)
        {
            string path_to_save;
            XmlDocument doc = Open_config(Config.connection,out path_to_save);

            XmlNode CCC = doc.GetElementsByTagName(item.ToString()).Item(0);
            try
            {
                CCC.InnerText= value;
                doc.Save(path_to_save);
                return true;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }





       // public static 

    }
}
