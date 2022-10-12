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
                 



            ///// Client Username
                XmlElement username = doc.CreateElement(string.Empty, "Username", string.Empty);
                XmlText usernametext = doc.CreateTextNode("user1");
                client_tree.AppendChild(username);
                username.AppendChild(usernametext);

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
            
            /////////// Use scheme
               XmlElement scheme = doc.CreateElement(string.Empty,"ConnectionScheme",string.Empty);
               XmlText sch = doc.CreateTextNode("No Encryption");
               client_tree.AppendChild(scheme);
               scheme.AppendChild(sch);

            doc.Save( "Config\\connection.conf");
            doc = null;
            
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

            //// Listen port
                    XmlElement listenport = doc.CreateElement(string.Empty, "Port", string.Empty);
                    XmlText port = doc.CreateTextNode("3333");
                    networkElement.AppendChild(listenport);
                    listenport.AppendChild(port);

            //// Allow being relay for others in peer to peer mode
                    XmlElement allowRelay = doc.CreateElement(string.Empty, "AllowBeingRelay", string.Empty);
                    XmlText AR = doc.CreateTextNode("true");
                    networkElement.AppendChild(allowRelay);
                    allowRelay.AppendChild(AR);


 
            
            doc.Save("Config\\peer2peer.conf");
            doc = null;
        }



        public static void write_DEFAULT_host_conf()
        {

            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

            // root
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            XmlElement main_element = doc.CreateElement(string.Empty, "Config", string.Empty);
            doc.AppendChild(main_element);

            ///////// network config tree
            XmlElement NetworkTree = doc.CreateElement(string.Empty, "Network", string.Empty);
            main_element.AppendChild(NetworkTree);

            ////// listen ip
                XmlElement listenip = doc.CreateElement(string.Empty,"ListenIP",string.Empty);
                XmlText ip = doc.CreateTextNode("127.0.0.1");
                NetworkTree.AppendChild(listenip);
                listenip.AppendChild(ip);

            ////// port
                XmlElement listenport = doc.CreateElement(string.Empty, "ListenPort", string.Empty);
                XmlText port = doc.CreateTextNode("4444");
                NetworkTree.AppendChild(listenport);
                listenport.AppendChild(port);

            ///////// Clients config tree

            XmlElement Clients_tree = doc.CreateElement(string.Empty, "Clients", string.Empty);
            main_element.AppendChild(Clients_tree);

            //////// Max_room_size
                XmlElement MaxRoomSize = doc.CreateElement(string.Empty, "MaxRoomSize",string.Empty);
                XmlText MRS = doc.CreateTextNode("2");
                Clients_tree.AppendChild(MaxRoomSize);
                MaxRoomSize.AppendChild(MRS);
            /////// UseWhitelist
                XmlElement usewhitelist = doc.CreateElement(string.Empty, "UseWhiteList", string.Empty);
                XmlText uwl = doc.CreateTextNode("false");
                Clients_tree.AppendChild(usewhitelist);
                usewhitelist.AppendChild(uwl);

            /// whitelist itself
                XmlElement whitelist = doc.CreateElement(string.Empty, "Whitelist", string.Empty);
                XmlText wl = doc.CreateTextNode( "192.168.0.1,192.168.0.1,172.0.0.1-172.0.0.220");
                Clients_tree.AppendChild(whitelist);
                whitelist.AppendChild(wl);

            /// banned ips
                XmlElement bannedlist = doc.CreateElement(string.Empty, "BannedIPs", string.Empty);
                XmlText banned = doc.CreateTextNode("0.1.2.3,0.1.2.4-0.1.2.255");
                Clients_tree.AppendChild(bannedlist);
                bannedlist.AppendChild(banned);

            doc.Save("Config\\server.conf");
            doc = null; 
        }
    }
}
