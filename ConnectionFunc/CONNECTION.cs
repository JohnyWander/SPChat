using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Linq.Expressions;
using System.Reflection;

namespace SPChat.ConnectionFunc
{
    internal class CONNECTION
    {
     
     
        // network
        private string ip;
        private string port;

        // client
        private string ClientChatColor;
        private string LoadChatMembersColors;

        public bool connection_ok = false;
        public Task connect;
        public CONNECTION(out Predicate<string> Disconnect_delegate,string ip_="127.0.0.1",string port_="3333")
        {
          
            ip = ip_;
            port = port_;

            if (Configuration.ConfigManipulator.ConnectionConf_GetConfig(Configuration.ConfigManipulator.ConnectionConfPools.ClientChatColor, out ClientChatColor)
            && (Configuration.ConfigManipulator.ConnectionConf_GetConfig(Configuration.ConfigManipulator.ConnectionConfPools.LoadChatMembersColors,out LoadChatMembersColors)))
            {
               
                    TcpClient client = new TcpClient();

                Disconnect_delegate = (ip_) =>
                {

                    if (client.Connected)
                    {
                        client.Close();
                        MessageBox.Show("delegate ran");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("delegate ran");
                        return false;
                    }
                       
                      
                    
                 
                };
                try
                {
                     connect = client.ConnectAsync(IPAddress.Parse(ip_), Convert.ToInt32(port_));
                    connect.GetAwaiter().GetResult();
                        connection_ok = true;

                    /// debug
                   // string test = "oogabooga";
                  //  byte[] mess = Encoding.UTF8.GetBytes(test);

                    
                  

                    
                }
                catch(Exception ex)
                {
                    Disconnect_delegate = (ip_) => { MessageBox.Show(ex.Message);return false; };
                    MessageBox.Show("Connection failed");
                    connection_ok = false;

                }




            }
            else
            {
                Disconnect_delegate=(ip_)=> { MessageBox.Show("something didn't work with connection");return false; };
            }

                   

        }

        




    }
}
