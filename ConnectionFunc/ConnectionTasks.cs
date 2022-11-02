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



        public async Task<int> SteerAsync(NetworkStream ns,int JobID)
        {
            
                await ns.WriteAsync(BitConverter.GetBytes(JobID));
            await ns.FlushAsync();

            return 0;
        }
        public  async Task<int> NegotiateBufferAsync(NetworkStream ns, int DesiredBufferLength)
        {
            
                await ns.WriteAsync(BitConverter.GetBytes(DesiredBufferLength));
            await ns.FlushAsync();
            

            

            return 0;
        }


        public async Task<int> SendMessageAsync(NetworkStream ns, byte[] Message)
        {
         //   MessageBox.Show(Encoding.UTF8.GetString(Message));
         
             
                await ns.WriteAsync(Message);

            await ns.FlushAsync();
            return 0;
        }


        public byte[] CreateBuffer(int length)
        {
            return  new byte[length];   
        }


    }
}
