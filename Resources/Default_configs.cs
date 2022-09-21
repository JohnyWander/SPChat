using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace SPChat.Resources
{
    internal static class DefaultConfigs
    {
       public static void write_DEFAULT_connection_conf()
        {
            XmlDocument doc = new XmlDocument();

            //xml declaration is recommended, but not mandatory
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

            //create the root element
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            XmlElement main_element = doc.CreateElement(string.Empty,"Config",string.Empty);
            doc.AppendChild(main_element);

            ///////////////////////////////////// NET TREE
            XmlElement net_tree = doc.CreateElement(string.Empty,"network",String.Empty);
            main_element.AppendChild(net_tree);

            /////////// IP
                XmlElement ip_element = doc.CreateElement(string.Empty, "IP", string.Empty);
                XmlText ip = doc.CreateTextNode("127.0.0.1");
                net_tree.AppendChild(ip_element);
                ip_element.AppendChild(ip);

            ////////// Port
                XmlElement port_element = doc.CreateElement(string.Empty, "Port", string.Empty);
                XmlText port = doc.CreateTextNode("3333");
                net_tree.AppendChild(port_element);
                port_element.AppendChild(port);

            ///////////////////////////////////////////////////// NET TREE

            /////////////////////// Client tree
            XmlElement client_tree = doc.CreateElement(string.Empty, "Client", string.Empty);
            main_element.AppendChild(client_tree);

            //////////// ClientChatColor
                XmlElement ccc = doc.CreateElement(string.Empty, "ClientChatColor", string.Empty);
                XmlText color = doc.CreateTextNode("Red");
                client_tree.AppendChild(ccc);
                ccc.AppendChild(color);

            /////////// LoadChatmembersColors
            ///
                XmlElement LcmC = doc.CreateElement(string.Empty, "LoadChatMembersColors", string.Empty);
                XmlText allowmembersColors = doc.CreateTextNode("true");
                client_tree.AppendChild(LcmC);
                LcmC.AppendChild(allowmembersColors);


            //XmlElement color
            

            doc.Save( "Config\\connection.conf");
            
        }


        public static void write_DEFAULT_peer2peer_conf()
        {

            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

            // root
            XmlElement  root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            XmlElement main_element = doc.CreateElement(string.Empty, "Config", string.Empty);
            doc.AppendChild(main_element);

            ///////// network tree
                XmlElement networkElement = doc.CreateElement(string.Empty,"NetworkThisPC", string.Empty);
                main_element.AppendChild(networkElement);
            ///// ListenIP
                    XmlElement listenip = doc.CreateElement(string.Empty, "ListenIP", string.Empty);
                    XmlText ip = doc.CreateTextNode("127.0.0.1");
                    networkElement.AppendChild(listenip);
                    listenip.AppendChild(ip);
                


            doc.Save("Config\\peer2peer.conf");
        }
    }
}
