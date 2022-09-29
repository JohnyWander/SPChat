using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPChat.HostFunc.Forms
{
    public partial class chat : Form
    {
        public chat()
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
            start_server.Enabled = false;
            Program.start_server();


        }
    }
}
