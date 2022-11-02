using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Channels;

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

        

        public CONNECTION(out Predicate<string> Disconnect_delegate, Common.ConnectionSchemes.schemes ConnectionScheme, string ip_="127.0.0.1",string port_="3333")
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
                        client.Dispose();
                        MessageBox.Show("delegate ran");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("delegate failed");
                        return false;
                    }
                };




                try
                {
                    
                     connect = client.ConnectAsync(IPAddress.Parse(ip_), Convert.ToInt32(port_));
                    connect.GetAwaiter().GetResult();
                        connection_ok = true;

                   NetworkStream ns =  client.GetStream();                                   // initial send - scheme negotiation


                    int x = (int)ConnectionScheme;
                    byte[] schemeByteMessege = BitConverter.GetBytes(x);

                 
                    ns.Write(schemeByteMessege, 0, schemeByteMessege.Length);
                    ns.FlushAsync().GetAwaiter().GetResult();

                    switch (x)
                    {
                        case 1:
                            //   MessageBox.Show("Using No encryption scheme (client)");
                            LaunchNoEncyptionModeClient noencryptionclient = new LaunchNoEncyptionModeClient(ns);
                            noencryptionclient.run();
                            



                        break;
                    }





                    
                  

                    
                }
                catch(Exception ex)
                {
                    Disconnect_delegate = (ip_) => { MessageBox.Show(ex.Message);return false; };
                    MessageBox.Show("Connection failed: " + ex.Message);
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
