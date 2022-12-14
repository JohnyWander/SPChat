using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace SPChat.HostFunc
{
    internal class LaunchNoEncryptionModeServer
    {
        byte[] MessageBuffer;
        string ip;
        int port;
      

        private INoEncryption HTask = new HostTasks();
        private Socket Client;
        private Func<bool, int> ConnectionCountChange;

        IDictionary<string, HandleClient> ConnectedClients;



        public LaunchNoEncryptionModeServer(Socket Client_,Func<bool,int> _ConnectionCountChange)
        {
            SetConnectedClients(Program.CurrentConnectionList);


            Client = Client_;
            
            ConnectionCountChange = _ConnectionCountChange;
        }

        void SetConnectedClients(IDictionary<string,HandleClient> dict)
        {
            ConnectedClients = dict;
        }


        bool Empty(int TaskResult)
        {
            if (TaskResult == 0 || TaskResult ==null)
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
            Task.Run(async () =>
            {
               //string endpoint = Client.RemoteEndPoint.ToString();
               
             


                bool breakswitch=false;
            while (true)
            {
                    SetConnectedClients(Program.CurrentConnectionList);
                    
                  
                   // MessageBox.Show("Listening for steer");
                    int SteerSwitch = await HTask.SteerAsync(Client);
                 //   int SteerSwitch = HTask.SteerAsync(Client).GetAwaiter().GetResult();

                    //MessageBox.Show("steer is "+Convert.ToString(SteerSwitch));
                    if (Empty(SteerSwitch)) { MessageBox.Show("EMPTY"); ConnectionCountChange(false); break;}
                    else
                    {
                        switch (SteerSwitch)
                        {
                            case 1: // Negotiate buffer
                                
                              //  MessageBox.Show("Negotiating buffer with client");
                                (int receivedBytes,int buffersize) = await HTask.NegotiateBufferAsync(Client);
                               // (int receivedBytes, int buffersize) =  HTask.NegotiateBufferAsync(Client).GetAwaiter().GetResult();
                                if (receivedBytes>0) {
                                    MessageBuffer = new byte[buffersize];
                                   // MessageBox.Show("buffer size is " + Convert.ToString(buffersize));
                                   
                                }

                            break;

                            case 2: // Receive Message
                               // MessageBox.Show("RECEIVE");
                                (int receivedMessagebytes, byte[] messageBytes) = await HTask.ReceiveMessageAsync(Client, MessageBuffer);
                               // (int receivedMessagebytes, byte[] messageBytes) = HTask.ReceiveMessageAsync(Client, MessageBuffer).GetAwaiter().GetResult();
                                string messege = Encoding.UTF8.GetString(messageBytes);
                              //  MessageBox.Show(messege);
                                Program.AddServerLogActionDelegate(messege);

                           await HTask.RelayAsync(ConnectedClients, Color.Red, "XD", messege);

                            break;

                        }









                        if (breakswitch) { break; }
                       // MessageBox.Show(Convert.ToString(SteerSwitch));
                    }
                    





            }
            });

        }


    }
}
