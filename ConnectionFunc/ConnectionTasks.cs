using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace SPChat.ConnectionFunc
{
    internal abstract class ConnectionTasks :  INoEncryptionClient
    {
        public async Task<int> SteerAsync(TcpClient socket)
        {
           NetworkStream ns = socket.GetStream();
        //   ns.WriteAsync()



            return 0;
        }
        public  async Task<int> NegotiateBufferAsync(TcpClient socket)
        {


            return 0;
        }

        public byte[] CreateBuffer(int length)
        {
            return  new byte[length];   
        }


    }
}
