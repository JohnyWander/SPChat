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
     
    
        public int Steer (Socket socket)
        {
            byte[] buffer = new byte[1024];
            int rec = socket.Receive(buffer);
            int steer = BitConverter.ToInt32(buffer,0);
            return steer;
        }
      
        public async Task<int>  SteerAsync(Socket socket)
        {

            byte[] buffer = CreateBuffer(10);
            int BytesReceived = await socket.ReceiveAsync(buffer,SocketFlags.None);


            

            return BitConverter.ToInt32(buffer, 0);
            
            
        }

        // //////////////////// bytesrecieved,buffersize
        public  async Task<Tuple<int,int>> NegotiateBufferAsync(Socket socket) // buffer size negotiation
        {
            byte[] buffer = CreateBuffer(1024);
            int bytesReceived = await socket.ReceiveAsync(buffer, SocketFlags.None);


            

            return new Tuple<int,int>(bytesReceived,BitConverter.ToInt32(buffer));
        }

        public async Task<Tuple<int, byte[]>> ReceiveMessageAsync(Socket socket, byte[] bufferr)
        {
            int bytesReceived = await socket.ReceiveAsync(bufferr, SocketFlags.None);
        
            MessageBox.Show("received:"+ Encoding.UTF8.GetString(bufferr));
            return new Tuple<int, byte[]>(bytesReceived, bufferr);

        }


      
        public byte[] CreateBuffer(int length)
        {
            return new byte[length];
        }


    }
}
