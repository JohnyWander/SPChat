using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SPChat.HostFunc
{
    internal abstract class ConnectionWithoutEncryptionServer
    {

        public abstract Task<int> NegotiateBuffer(TcpListener listener);
    }
}
