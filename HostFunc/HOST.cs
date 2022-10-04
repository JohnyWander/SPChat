using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace SPChat.HostFunc
{
    internal class HOST
    {
        private Func<string, bool> set_countGUI;

        public CancellationTokenSource cancelConnectionsToken = new CancellationTokenSource();
        // network
        private string ip;
        private string port;

        // clients
        private string MaxRoomSize;
        private string UseWhiteList;
        private string Whitelist;
        private List<string> WhitelistedIPs = new List<string>();

        private string Banned;
        private List<string> BannedIPs = new List<string>();


        int clients_connected_count = 0;
        private IDictionary<string, HandleClient> clients_connected  = new Dictionary<string, HandleClient>();
        public HOST(out Predicate<string> StopServerDelegate,Func<string,bool> set_Conn_Count)
        {
            set_countGUI = set_Conn_Count;
            if (Configuration.ConfigManipulator.HostConf_GetConfig(Configuration.ConfigManipulator.HostConfPools.ListenIP, out ip)
            && Configuration.ConfigManipulator.HostConf_GetConfig(Configuration.ConfigManipulator.HostConfPools.ListenPort, out port)
            && Configuration.ConfigManipulator.HostConf_GetConfig(Configuration.ConfigManipulator.HostConfPools.MaxRoomSize, out MaxRoomSize)
            && Configuration.ConfigManipulator.HostConf_GetConfig(Configuration.ConfigManipulator.HostConfPools.UseWhiteList, out UseWhiteList)
            && Configuration.ConfigManipulator.HostConf_GetConfig(Configuration.ConfigManipulator.HostConfPools.Whitelist, out UseWhiteList)
            && Configuration.ConfigManipulator.HostConf_GetConfig(Configuration.ConfigManipulator.HostConfPools.BannedIPs,out Banned))
            {
                int port_ = Convert.ToInt32(port);

                TcpListener listener = new TcpListener(IPAddress.Parse(ip), Convert.ToInt32(port));

                var listenertask = ServerListener(cancelConnectionsToken.Token, listener);




                StopServerDelegate = (ip) => { listener.Stop() ; return true; };

                    listenertask.GetAwaiter().GetResult();



            }
            else
            {
                StopServerDelegate = null;
            }



            
            //TcpListener connectionListener = new TcpListener



       

        }

        
        public async Task ServerListener(CancellationToken cts,TcpListener listener)
        {
            
            
            
            listener.Start();
            while (!cts.IsCancellationRequested )
            {
                try
                {
                    Socket client = await listener.AcceptSocketAsync();
                    string endpoint = client.RemoteEndPoint.ToString();
                    clients_connected_count++;
                    int new_count = clients_connected_count;
                    clients_connected.Add(endpoint, new HandleClient(client, set_countGUI));
                   
                    set_countGUI(Convert.ToString(clients_connected_count));
                    
                    
                }
                catch(System.Net.Sockets.SocketException)
                {
                    return;
                }

            }


        }

     



    }


        public class HandleClient
        {
          private Socket Client;
          private CancellationTokenSource cts = new CancellationTokenSource();  
  

           public HandleClient(Socket socket, Func<string, bool> set_Conn_Count)
           {
            Client = socket;

            Task.Run(async () =>
            {
                //TaskCompletionSource tcs = new TaskCompletionSource<bool>();





                byte[] buffer = new byte[1024];
                Task<int> result = Client.ReceiveAsync(buffer,SocketFlags.None);
                //await Client.ReceiveAsync(args);
                await result;

                

                string received = Encoding.UTF8.GetString(buffer);
                if (received == null&&!Client.Connected) 
                {
                    
                    MessageBox.Show("CONNECTION CLOSED");
                }


            });
            

            


           }
   


        }


}
