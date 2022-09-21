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
            }
            else
            {
                string[] paths = Directory.GetFiles("Config");
                if (!paths.Contains("connection.conf"))
                {
                    Resources.DefaultConfigs.write_DEFAULT_connection_conf();
                }



            }



        }
    }
}
