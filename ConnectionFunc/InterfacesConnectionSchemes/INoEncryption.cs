using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace SPChat.ConnectionFunc
{
    internal interface INoEncryption
    {
        public Task<int> NegotiateBufferAsync(Socket client);

    }
}
