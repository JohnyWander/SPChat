using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace SPChat.HostFunc
{
    internal class HostTasks : INoEncryption
    {
     
        
       
        public async Task<int>  SteerAsync(Socket socket)
        {

            byte[] buffer = CreateBuffer(10);
            int BytesReceived = await socket.ReceiveAsync(buffer,SocketFlags.None);




            return BitConverter.ToInt32(buffer, 0);
            
            
        }


        public  async Task<int> NegotiateBufferAsync(Socket socket) // buffer size negotiation
        {



            return 0;
        }

      
        public byte[] CreateBuffer(int length)
        {
            return new byte[length];
        }


    }
}
