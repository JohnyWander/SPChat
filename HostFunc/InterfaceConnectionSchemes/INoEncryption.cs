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
        public int Steer(Socket socket);
        public Task<int> SteerAsync(Socket socket);
        public Task<Tuple<int,int>> NegotiateBufferAsync(Socket socket);// buffer size negotiation

        public Task<Tuple<int, byte[]>> ReceiveMessageAsync(Socket socket, byte[] buffer);
    }
}
