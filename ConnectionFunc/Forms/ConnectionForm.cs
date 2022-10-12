using SPChat.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SPChat.ConnectionFunc.Forms
{
    public partial class ConnectionForm : Form
    {
        private Color THISClientColor;
        private string THISClientName;
        public ConnectionForm()
        {
            InitializeComponent();
            string ip, port;
            Configuration.ConfigManipulator.ConnectionConf_GetConfig(Configuration.ConfigManipulator.ConnectionConfPools.IP, out ip);
            Configuration.ConfigManipulator.ConnectionConf_GetConfig(Configuration.ConfigManipulator.ConnectionConfPools.Port, out port);
            this.IP.Text = ip;
            this.port.Text = port;

            string colorstring;
            

           // THISClientColor = Color.Fro

        }
        ///EVENTS -
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Connect_server_Click(object sender, EventArgs e)
        {
            Configuration.ConfigManipulator.ConnectionConf_ChangeConfig(Configuration.ConfigManipulator.ConnectionConfPools.IP, this.IP.Text);
            Configuration.ConfigManipulator.ConnectionConf_ChangeConfig(Configuration.ConfigManipulator.ConnectionConfPools.Port, this.port.Text);

            string p;
            Configuration.ConfigManipulator.ConnectionConf_GetConfig(Configuration.ConfigManipulator.ConnectionConfPools.ConnectionScheme, out p); ;

            char[] withoutspaces = p.ToCharArray().Where(p => !Char.IsWhiteSpace(p)).ToArray();
            string withoutspaces_string = new string(withoutspaces);

            Common.ConnectionSchemes.schemes selected = (ConnectionSchemes.schemes)Enum.Parse(typeof(ConnectionSchemes.schemes), withoutspaces);

            if (Program.start_connection(this.IP.Text, this.port.Text,selected).GetAwaiter().GetResult()==true)
            {
                this.FormClosing += new FormClosingEventHandler((object sender, FormClosingEventArgs e) => Program.Disconnect_delegate(null));
                this.Disconnect_button.Enabled = true;
                this.Connect_server.Enabled = false;

                this.Width =282+400;
                this.Height = 252+100;

               // TextBox txtbox = new TextBox();
              //  this.Controls.Add(txtbox);
               // txtbox.Location = new Point(200, 200);
               // txtbox.Text = "XD";
            }else
            {
                this.Disconnect_button.Enabled = false;
                MessageBox.Show("Connection failed");

            }
        }

        private void Disconnect_button_Click(object sender, EventArgs e)
        {
           if(Program.Disconnect_delegate(this.IP.Text))
            {
                MessageBox.Show("Disconnected  Successfully");
                this.Disconnect_button.Enabled = false;
                this.Connect_server.Enabled = true;
            }
            else
            {
                MessageBox.Show(">NO CONNECTION");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputTextEntered(object sender,KeyEventArgs button)
        {

            if (button.KeyCode == Keys.Enter)
            {

            }

        }

        /////////////////// Other
        
        private void InputChatMessege(Color MessegeColor, string Messege,string username)
        {
            string text = Common.Methods.DateLog() + " "+ username;


            ChatBox.SelectionStart = ChatBox.TextLength;
            ChatBox.SelectionLength = 0;

            ChatBox.SelectionColor = MessegeColor;
            ChatBox.AppendText(text);
            ChatBox.SelectionColor = ChatBox.ForeColor;


        }

    }
}
