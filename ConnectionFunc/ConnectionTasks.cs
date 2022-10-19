using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace SPChat.ConnectionFunc
{
    internal  class ConnectionTasks :  INoEncryptionClient
    {
        public enum TaskList
        {
            SteerAsync =1,
            NegotiateBuffer=2

        }



        public async Task<int> SteerAsync(TcpClient socket,int JobID)
        {
            using (NetworkStream ns = socket.GetStream())
            {
                await ns.WriteAsync(BitConverter.GetBytes(JobID));

            }

            return 0;
        }
        public  async Task<int> NegotiateBufferAsync(TcpClient socket, int DesiredBufferLength)
        {
            using (NetworkStream ns = socket.GetStream())
            {
                await ns.WriteAsync(BitConverter.GetBytes(DesiredBufferLength));
            }



            return 0;
        }

        public byte[] CreateBuffer(int length)
        {
            return  new byte[length];   
        }


    }
}
