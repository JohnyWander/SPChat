﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPChat.ConnectionFunc.Forms
{
    public partial class ConnectionForm : Form
    {
        
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Connect_server_Click(object sender, EventArgs e)
        {
            Configuration.ConfigManipulator.ConnectionConf_ChangeConfig(Configuration.ConfigManipulator.ConnectionConfPools.IP, this.IP.Text);
            Configuration.ConfigManipulator.ConnectionConf_ChangeConfig(Configuration.ConfigManipulator.ConnectionConfPools.Port, this.port.Text);
            if (Program.start_connection(this.IP.Text, this.port.Text).GetAwaiter().GetResult()==true)
            {
                this.Disconnect_button.Enabled = true;
                TextBox txtbox = new TextBox();
                this.Controls.Add(txtbox);
                txtbox.Location = new Point(200, 200);
                txtbox.Text = "XD";
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
            }
            else
            {
                MessageBox.Show(">??????????");
            }

        }
    }
}
