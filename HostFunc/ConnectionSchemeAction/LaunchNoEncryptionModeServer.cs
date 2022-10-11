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

        private INoEncryption HTask = new HostTasks();
        private Socket Client;
        private Func<bool, int> ConnectionCountChange;
        public LaunchNoEncryptionModeServer(Socket Client_,Func<bool,int> _ConnectionCountChange)
        {
            Client = Client_;
            ConnectionCountChange = _ConnectionCountChange;
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
            while (true)
            {
                    MessageBox.Show("Listening for steer");
                    int SteerSwitch =await HTask.SteerAsync(Client);
                    if (Empty(SteerSwitch)) { break;}
                    





            }
            });

        }


    }
}
