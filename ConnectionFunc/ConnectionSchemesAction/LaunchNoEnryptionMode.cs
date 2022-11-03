using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
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

        CancellationTokenSource CancelListenFromServer = new CancellationTokenSource();
     
      
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
               

              //  await Task.Delay(1000);
                await  ClientTasks.SteerAsync(Client, (int)ServerSteers.SendReceiveMessege);
              //  await Task.Delay(1000);
                
                await ClientTasks.SendMessageAsync(Client, MessegeBytes);

            //    await Task.Delay(1000);

                await ListenForServer();

              

            });



        }
        public LaunchNoEncyptionModeClient(NetworkStream ns)
        {
            Client = ns;
      
            Program.SendMessegeToServer = ClientWantsToSendMessege;


            Task.Run(async () =>
            {

                await ListenForServer();

            });



        }



        private async Task ListenForServer()
        {

          //  MessageBox.Show("Listening for server output");
            byte[] receiveBuffer = new byte[1024];

            
                int bytes_received = await Client.Socket.ReceiveAsync(receiveBuffer, SocketFlags.None, CancelListenFromServer.Token);
                MessageBox.Show("Server Relayed:" + Encoding.UTF8.GetString(receiveBuffer));
            

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
