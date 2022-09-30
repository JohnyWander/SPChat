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



        private IDictionary<string,HandleClient> clients_connected = new Dictionary<string,HandleClient>();
        public HOST()
        {
            if (Configuration.ConfigManipulator.HostConf_GetConfig(Configuration.ConfigManipulator.HostConfPools.ListenIP, out ip)
            && Configuration.ConfigManipulator.HostConf_GetConfig(Configuration.ConfigManipulator.HostConfPools.ListenPort, out port)
            && Configuration.ConfigManipulator.HostConf_GetConfig(Configuration.ConfigManipulator.HostConfPools.MaxRoomSize, out MaxRoomSize)
            && Configuration.ConfigManipulator.HostConf_GetConfig(Configuration.ConfigManipulator.HostConfPools.UseWhiteList, out UseWhiteList)
            && Configuration.ConfigManipulator.HostConf_GetConfig(Configuration.ConfigManipulator.HostConfPools.Whitelist, out UseWhiteList)
            && Configuration.ConfigManipulator.HostConf_GetConfig(Configuration.ConfigManipulator.HostConfPools.BannedIPs,out Banned))
            {
                int port_ = Convert.ToInt32(port);



                var listenertask = ServerListener(cancelConnectionsToken.Token, ip, port_);
                    listenertask.GetAwaiter().GetResult();

                
               

            }



            
            //TcpListener connectionListener = new TcpListener



       

        }

        
        public async Task ServerListener(CancellationToken cts,string ip,int port)
        {
            TcpListener listener = new TcpListener(IPAddress.Parse(ip),port);

            
            listener.Start(); 
            while (!cts.IsCancellationRequested)
            {
               
                Socket client = await listener.AcceptSocketAsync();
               string endpoint = client.RemoteEndPoint.ToString();

                clients_connected.Add(endpoint, new HandleClient(client));



            }


        }

     



    }


        public class HandleClient
        {
          private Socket Client;
          private CancellationTokenSource cts = new CancellationTokenSource();  
  

           public HandleClient(Socket socket)
           {
            Client = socket;
            

            

            


           }
        private async Task ClientTask()
        {






        }


        }


}
