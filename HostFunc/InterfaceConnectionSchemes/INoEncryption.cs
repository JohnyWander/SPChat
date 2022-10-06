using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SPChat.HostFunc
{
    internal interface INoEncryption
    {
        public Task<int> SteerAsync(Socket socket);
        public  Task<int> NegotiateBufferAsync(Socket socket);// buffer size negotiation
    }
}
