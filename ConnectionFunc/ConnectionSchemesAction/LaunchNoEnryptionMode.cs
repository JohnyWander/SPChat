using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SPChat.ConnectionFunc
{
    internal class LaunchNoEncyptionModeClient
    {
        INoEncryptionClient ClientTasks;
        private TcpClient Client;

        public LaunchNoEncyptionModeClient(TcpClient _Client)
        {
            Client = _Client;
        }

        public void run()
        {

        }

    }
}
