using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPChat.Initialization
{
    internal static class CheckFiles
    {
        public static void run()
        {
            if (!Directory.Exists("Config"))
            {
                Directory.CreateDirectory("Config");
                MessageBox.Show("NIMO");
            }
            else
            {

                string folder = "Config\\";
         
                    if (!File.Exists(folder+"connection.conf"))
                    {
                        MessageBox.Show("NIE");
                        Resources.DefaultConfigs.write_DEFAULT_connection_conf();
                    }
                    else { }
                    
                    if (!File.Exists(folder + "peer2peer.conf"))
                    {
                        Resources.DefaultConfigs.write_DEFAULT_peer2peer_conf();
                    }
                    else { }

                    if (!File.Exists(folder + "server.conf"))
                    {
                        Resources.DefaultConfigs.write_DEFAULT_host_conf();
                    }
                    else { }

                

            }



        }
    }
}
