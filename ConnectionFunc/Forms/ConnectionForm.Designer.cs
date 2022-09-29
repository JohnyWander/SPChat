namespace SPChat.ConnectionFunc.Forms
{
    partial class ConnectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.Connect_server = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(93, 31);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(100, 23);
            this.IP.TabIndex = 1;
            string outtt;
            Configuration.ConfigManipulator.ConnectionConf_GetConfig(Configuration.ConfigManipulator.ConnectionConfPools.IP, out outtt);
            this.IP.Text = outtt;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(93, 59);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(100, 23);
            this.port.TabIndex = 3;
            string outttt;
            Configuration.ConfigManipulator.ConnectionConf_GetConfig(Configuration.ConfigManipulator.ConnectionConfPools.Port, out outttt);
            this.port.Text = outttt;
            // 
            // Connect_server
            // 
            this.Connect_server.Location = new System.Drawing.Point(105, 88);
            this.Connect_server.Name = "Connect_server";
            this.Connect_server.Size = new System.Drawing.Size(75, 23);
            this.Connect_server.TabIndex = 4;
            this.Connect_server.Text = "Connect";
            this.Connect_server.UseVisualStyleBackColor = true;
            this.Connect_server.Click += new System.EventHandler(this.Connect_server_Click);
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(307, 275);
            this.Controls.Add(this.Connect_server);
            this.Controls.Add(this.port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.label1);
            this.Name = "ConnectionForm";
            this.Text = "SPChat | Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox IP;
        private Label label2;
        private TextBox port;
        private Button Connect_server;
    }
}