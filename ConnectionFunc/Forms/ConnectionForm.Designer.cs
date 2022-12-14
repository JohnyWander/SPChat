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
            this.Disconnect_button = new System.Windows.Forms.Button();
            this.ChatBox = new System.Windows.Forms.RichTextBox();
            this.InputBox = new System.Windows.Forms.TextBox();
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
            // Disconnect_button
            // 
            this.Disconnect_button.Enabled = false;
            this.Disconnect_button.Location = new System.Drawing.Point(105, 117);
            this.Disconnect_button.Name = "Disconnect_button";
            this.Disconnect_button.Size = new System.Drawing.Size(75, 23);
            this.Disconnect_button.TabIndex = 5;
            this.Disconnect_button.Text = "Disconnect";
            this.Disconnect_button.UseVisualStyleBackColor = true;
            this.Disconnect_button.Click += new System.EventHandler(this.Disconnect_button_Click);
            // 
            // ChatBox
            // 
            this.ChatBox.Location = new System.Drawing.Point(268, 12);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.ReadOnly = true;
            this.ChatBox.Size = new System.Drawing.Size(353, 223);
            this.ChatBox.TabIndex = 6;
            this.ChatBox.Text = "";
            // 
            // InputBox
            // 
            this.InputBox.Enabled = false;
            this.InputBox.Location = new System.Drawing.Point(268, 250);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(353, 23);
            this.InputBox.TabIndex = 7;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTextEntered);
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(706, 309);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.Disconnect_button);
            this.Controls.Add(this.Connect_server);
            this.Controls.Add(this.port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
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
        private Button Disconnect_button;
        private RichTextBox ChatBox;
        private TextBox InputBox;
    }
}