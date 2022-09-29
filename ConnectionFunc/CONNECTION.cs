using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                MessageBox.Show("GIT GOOD");
            }

                   

        }


    }
}
