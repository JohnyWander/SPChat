using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Channels;
namespace SPChat.HostFunc.Forms
{
    public partial class ServerForm : Form
    {
        public Func<string,bool> insert_connection_count;

        Channel<KeyValuePair<Func<string,bool>,string>> GuiActionQueue = Channel.CreateUnbounded<KeyValuePair<Func<string,bool>,string>>();

      
        public ServerForm()
        {
            InitializeComponent();




        }

        private void chat_Load(object sender, EventArgs e)
        {

        }

        private void xd (object sender,EventArgs e)
        {
            MessageBox.Show("XDDD");
        }

        private void start_server_Click(object sender, EventArgs e)
        {
            insert_connection_count = (string s) =>
            {
                try
                {
                    Action OwnerThreadLaunch = () =>
                    {
                        this.ConnectedUsersCounter.Text = s;
                    };
                    this.ConnectedUsersCounter.Invoke(OwnerThreadLaunch); 

                    return true;
                }catch(Exception e)
                {
                    return false;
                }
              
              
                
            };

            if (Program.start_server(this.insert_connection_count))
            {
                start_server.Enabled = false;
                StopButton.Enabled = true;
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
           if(Program.StopServer_delegate("X"))
            {
                start_server.Enabled = true;
                StopButton.Enabled = false;
            }
        }

      
    }
}
