using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace SPChat.ConnectionFunc
{
    internal abstract class ConnectionTasks : INoEncryption
    {
        public  async Task<int> NegotiateBufferAsync(Socket socket)
        {


            return 0;
        }
    }
}
