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
            LoadChatMembersColors,
            ConnectionScheme,
            Username,

        }
        public enum HostConfPools
        {
            ListenIP,
            ListenPort,
            MaxRoomSize,
            UseWhiteList,
            Whitelist,
            BannedIPs

        }


        public static XmlDocument Open_config(Config conf,out string path)
        {
           // MessageBox.Show(conf.ToString());
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
                doc = null;
                return true;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                doc = null;
                return false;
            }
        }

        public static bool ConnectionConf_GetConfig(ConnectionConfPools item, out string outValue)
        {
            string readpath;
            try
            {

                XmlDocument doc = Open_config(Config.connection,out readpath);
                XmlNode CCC = doc.GetElementsByTagName(item.ToString()).Item(0);
                outValue = CCC.InnerText;
                doc = null;
                return true;
            }
            catch
            {
                outValue = "?";
                return false;
            }
        }
        //////////////////// Host conf

        public static bool HostConf_ChangeConfig(HostConfPools item, string value)
        {
            string path_to_save;
            XmlDocument doc = Open_config(Config.server, out path_to_save);

            XmlNode CCC = doc.GetElementsByTagName(item.ToString()).Item(0);
            try
            {
                CCC.InnerText = value;
                doc.Save(path_to_save);
                doc = null;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                doc = null;
                return false;
            }
        }

        public static bool HostConf_GetConfig(HostConfPools item, out string outValue)
        {
            string readpath;
            try
            {

                XmlDocument doc = Open_config(Config.server, out readpath);
                XmlNode CCC = doc.GetElementsByTagName(item.ToString()).Item(0);
                outValue = CCC.InnerText;
                doc = null;
                return true;
            }
            catch
            {
                outValue = "?";
                return false;
            }
        }



        // public static 

    }
}
