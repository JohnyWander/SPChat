using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;
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


        public CONNECTION(string ip_="127.0.0.1",string port_="3333")
        {
            ip = ip_;
            port = port_;

            if (Configuration.ConfigManipulator.ConnectionConf_GetConfig(Configuration.ConfigManipulator.ConnectionConfPools.ClientChatColor, out ClientChatColor)
            && (Configuration.ConfigManipulator.ConnectionConf_GetConfig(Configuration.ConfigManipulator.ConnectionConfPools.LoadChatMembersColors,out LoadChatMembersColors)))
            {
                TcpClient client = new TcpClient();
                

                Task connect = client.ConnectAsync(IPAddress.Parse(ip_), Convert.ToInt32(port_));
                connect.GetAwaiter().GetResult();

                if (client.Connected)
                {
                    MessageBox.Show("Connection success");
                }


            }

                   

        }


    }
}
