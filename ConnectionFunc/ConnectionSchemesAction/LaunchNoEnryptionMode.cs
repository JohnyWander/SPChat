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

        public LaunchNoEncyptionModeClient(TcpClient _Client)
        {
            Client = _Client;
        }

        public void ClientWantsToSendMessege()
        {



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
                    while (Client.Connected)
                    {
                          await TaskQueue.Reader.WaitToReadAsync();

                          var pair = await TaskQueue.Reader.ReadAsync();
                          Action<object[]> Job = pair.Key;
                          object[] args = pair.Value;

                        Job(args);
                    }
                });






            



        }

        public void Add_job_to_queue(int selector, object[] args)
        {
            
                switch (selector)
                {
                    case 1: /// SteerAsync

                        Action<object[]> steerasyncAction = (args) =>
                        {
                             ClientTasks.SteerAsync(this.Client, (int)args[0]);
                        };
                             KeyValuePair<Action<object[]>, object[]> valuepair = new KeyValuePair<Action<object[]>, object[]>(steerasyncAction, args);
                             TaskQueue.Writer.TryWrite(valuepair);

                    break;
                }



            


        }




    }
}
