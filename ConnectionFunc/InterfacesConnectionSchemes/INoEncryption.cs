using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace SPChat.ConnectionFunc
{
    internal interface INoEncryptionClient
    {
        public Task<int> SteerAsync(TcpClient client,int JobID);
        public Task<int> NegotiateBufferAsync(TcpClient client);


        public byte[] CreateBuffer(int length);
    }
}
