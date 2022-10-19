using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SPChat.ConnectionFunc
{
    internal class LaunchNoEncyptionModeClient
    {
        INoEncryptionClient ClientTasks = new ConnectionTasks();
        private TcpClient Client;

        private Channel<KeyValuePair<Action<object[]>, object[]>> TaskQueue = Channel.CreateUnbounded<KeyValuePair<Action<object[]>, object[]>>();

        private enum Jobs // jobs list for client
        {
            SteerAsync = 1,
            NegotiateBufferAsync = 2
        } 

        private enum ServerSteers  // jobs id's to send to server
        {
              SendNegotiateBuffer = 1

        }

        public void ClientWantsToSendMessege(string username, string Messege)
        {
            int MessegeLength = Messege.Length;

            Add_job_to_queue(Jobs.SteerAsync, new object[] { (int)ServerSteers.SendNegotiateBuffer }); // setting server to listen for messege buffer negotiation
            Add_job_to_queue(Jobs.NegotiateBufferAsync, new object[] { MessegeLength });
            
        }
        public LaunchNoEncyptionModeClient(TcpClient _Client)
        {
            Client = _Client;
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
          
                Task.Run(async()=>
                {
                    while (await TaskQueue.Reader.WaitToReadAsync())
                    {
                          

                          var pair = await TaskQueue.Reader.ReadAsync();
                          Action<object[]> Job = pair.Key;
                          object[] args = pair.Value;

                        Job(args);
                    }
                });






            



        }

        private void Add_job_to_queue(Jobs job, object[] args)
        {
            
                switch ((int)job)
                {
                    case 1: /// SteerAsync

                        Action<object[]> steerasyncAction = (args) =>
                        {
                             ClientTasks.SteerAsync(this.Client, (int)args[0]);
                        };
                             KeyValuePair<Action<object[]>, object[]> valuepairSteerAsync = new KeyValuePair<Action<object[]>, object[]>(steerasyncAction, args);
                             TaskQueue.Writer.TryWrite(valuepairSteerAsync);
                    break;

                   case 2: /// Negotiate buffer

                    Action<object[]> NegotiateBufferAction = (args) =>
                    {
                        ClientTasks.NegotiateBufferAsync(this.Client, (int)args[0]);
                    };
                    KeyValuePair<Action<object[]>, object[]> valuepairNegotiateBuffer = new KeyValuePair<Action<object[]>, object[]>(NegotiateBufferAction, args);
                    TaskQueue.Writer.TryWrite(valuepairNegotiateBuffer);

                    break;
                }



            


        }




    }
}
