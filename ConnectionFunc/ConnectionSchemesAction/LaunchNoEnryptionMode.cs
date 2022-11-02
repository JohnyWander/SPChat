using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SPChat.ConnectionFunc
{
    internal class LaunchNoEncyptionModeClient
    {
        string ip, port;
        INoEncryptionClient ClientTasks = new ConnectionTasks();
        private NetworkStream Client;

      
        private enum Jobs // jobs list for client
        {
            SteerAsync = 1,
            NegotiateBufferAsync = 2,
            ReceiveMessegeAsync =3
        } 

        private enum ServerSteers  // jobs id's to send to server
        {
              SendNegotiateBuffer = 1,
              SendReceiveMessege = 2

        }

        public void ClientWantsToSendMessege(string username, string Messege)
        {
            Task.Run(async () => {
            byte[] MessegeBytes = Encoding.UTF8.GetBytes(Messege);
            int MessegeLength = MessegeBytes.Length;

                await ClientTasks.SteerAsync(Client, (int)ServerSteers.SendNegotiateBuffer);
                await Task.Delay(1000);
                await ClientTasks.NegotiateBufferAsync(Client, MessegeLength);
               

                await Task.Delay(1000);
                await  ClientTasks.SteerAsync(Client, (int)ServerSteers.SendReceiveMessege);
                await Task.Delay(1000);
                await ClientTasks.SteerAsync(Client, (int)ServerSteers.SendReceiveMessege);
                await ClientTasks.SendMessageAsync(Client, MessegeBytes);





            });



        }
        public LaunchNoEncyptionModeClient(NetworkStream ns)
        {
            Client = ns;
      
            Program.SendMessegeToServer = ClientWantsToSendMessege;
        }









        bool Empty(int TaskResult)
        {
            if (TaskResult == 0 || TaskResult == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void run()
        {
          
       






            



        }

   


    }
}
