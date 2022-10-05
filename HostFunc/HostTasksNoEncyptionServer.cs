using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace SPChat.HostFunc
{
    internal class HostTasksNoEncyptionServer : ConnectionWithoutEncryptionServer
    {
    
        public override async Task<int> NegotiateBuffer(TcpListener listener) // 
        {



            return 0;
        }

      
    }
}
