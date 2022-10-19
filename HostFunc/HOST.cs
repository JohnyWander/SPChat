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




       public int clients_connected_count = 0;

        public Func<bool,int> setClientsCount;

        private IDictionary<string, HandleClient> clients_connected  = new Dictionary<string, HandleClient>();
        public HOST(out Predicate<string> StopServerDelegate,Func<string,bool> set_Conn_Count_GUI)
        {

            setClientsCount = (bool x) =>
            {
                if (x)
                {
                    clients_connected_count++;
                    return clients_connected_count;
                }
                else
                {
                    clients_connected_count--;
                    return clients_connected_count;
                }
            };




            set_countGUI = set_Conn_Count_GUI;
            if (Configuration.ConfigManipulator.HostConf_GetConfig(Configuration.ConfigManipulator.HostConfPools.ListenIP, out ip)
            && Configuration.ConfigManipulator.HostConf_GetConfig(Configuration.ConfigManipulator.HostConfPools.ListenPort, out port)
            && Configuration.ConfigManipulator.HostConf_GetConfig(Configuration.ConfigManipulator.HostConfPools.MaxRoomSize, out MaxRoomSize)
            && Configuration.ConfigManipulator.HostConf_GetConfig(Configuration.ConfigManipulator.HostConfPools.UseWhiteList, out UseWhiteList)
            && Configuration.ConfigManipulator.HostConf_GetConfig(Configuration.ConfigManipulator.HostConfPools.Whitelist, out UseWhiteList)
            && Configuration.ConfigManipulator.HostConf_GetConfig(Configuration.ConfigManipulator.HostConfPools.BannedIPs,out Banned))
            {







                int port_ = Convert.ToInt32(port);

                TcpListener listener = new TcpListener(IPAddress.Parse(ip), Convert.ToInt32(port));
                if (listener.LocalEndpoint != null) { Program.AddServerLogActionDelegate($"Successfully started server on:{listener.LocalEndpoint}"); }
                var listenertask = ServerListener(cancelConnectionsToken.Token, listener,setClientsCount);

                


                StopServerDelegate = (ip) => { listener.Stop() ; return true; };

                    listenertask.GetAwaiter().GetResult();



            }
            else
            {
                StopServerDelegate = null;
            }



            
            //TcpListener connectionListener = new TcpListener



       

        }

        
        public async Task ServerListener(CancellationToken cts,TcpListener listener, Func<bool,int> setClientsCount)
        {




            listener.Start();
            while (!cts.IsCancellationRequested )
            {
                try
                {
                    Socket client = await listener.AcceptSocketAsync();
                    
                    string endpoint = client.RemoteEndPoint.ToString();

                    Program.AddServerLogActionDelegate($"Client connected from: {endpoint}");
                    clients_connected_count++;
                    int new_count = clients_connected_count;
                    clients_connected.Add(endpoint, new HandleClient(client, set_countGUI,setClientsCount));
                   
                    set_countGUI(Convert.ToString(clients_connected_count));
                    
                    
                }
                catch(System.Net.Sockets.SocketException)
                {
                    return;
                }

            }


        }

     



    }


        internal class HandleClient
        {
          private Socket Client;
          private CancellationTokenSource cts = new CancellationTokenSource();

          public LaunchNoEncryptionModeServer NoEncryptionModeServer;
          


           public HandleClient(Socket socket, Func<string, bool> set_Conn_Count_GUI,Func<bool,int>set_HOST_conn_count)
           {
            Client = socket;
            string username = null;

            Task.Run(async () =>
            {
                //TaskCompletionSource tcs = new TaskCompletionSource<bool>();

             

                    byte[] buffer = new byte[32];                                      // initial listen for determining connection scheme
                    Task<int> result = Client.ReceiveAsync(buffer, SocketFlags.None);
                    //await Client.ReceiveAsync(args);
                    await result;

                    int ConnectionSchemeSwitch = BitConverter.ToInt32(buffer, 0);
                    //  MessageBox.Show(Convert.ToString(ConnectionSchemeSwitch));
                    

                    switch (ConnectionSchemeSwitch)
                    {
                        case 1:
                            MessageBox.Show("server using scheme 1");
                        NoEncryptionModeServer = new LaunchNoEncryptionModeServer(Client,set_HOST_conn_count);

                            NoEncryptionModeServer.run();

                           

                        break;


                    }
                    




              



                    if (result.Result==0)
                   {
                        set_Conn_Count_GUI(Convert.ToString(set_HOST_conn_count(false)));

                        if (username == null||username=="") { Program.AddServerLogActionDelegate($"Client disconnected: {Client.RemoteEndPoint}"); }
                        else { Program.AddServerLogActionDelegate($"Client disconnected:{username}"); }

                 

                    }

                    
                


                
            });
            

            


           }



    }

   


}
