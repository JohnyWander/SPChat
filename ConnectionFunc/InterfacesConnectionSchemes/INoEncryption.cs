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
        public Task<int> SteerAsync(NetworkStream ns, int JobID);
        public Task<int> NegotiateBufferAsync(NetworkStream ns, int DesiredBufferLength);

        public Task<int> SendMessageAsync(NetworkStream ns, byte[] Message);
        public byte[] CreateBuffer(int length);
    }
}
