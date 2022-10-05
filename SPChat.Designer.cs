namespace SPChat
{
    partial class SPChat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectServer_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Host_button = new System.Windows.Forms.Button();
            this.open_connect_config = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnectServer_button
            // 
            this.ConnectServer_button.Location = new System.Drawing.Point(12, 66);
            this.ConnectServer_button.Name = "ConnectServer_button";
            this.ConnectServer_button.Size = new System.Drawing.Size(152, 23);
            this.ConnectServer_button.TabIndex = 0;
            this.ConnectServer_button.Text = "Connect Server";
            this.ConnectServer_button.UseVisualStyleBackColor = true;
            this.ConnectServer_button.Click += new System.EventHandler(this.ConnectServer_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Peer to Peer Mode";
            this.button2.UseVisualStyleBackColor = true;
           // this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Host_button
            // 
            this.Host_button.Location = new System.Drawing.Point(12, 157);
            this.Host_button.Name = "Host_button";
            this.Host_button.Size = new System.Drawing.Size(152, 23);
            this.Host_button.TabIndex = 2;
            this.Host_button.Text = "Host";
            this.Host_button.UseVisualStyleBackColor = true;
            this.Host_button.Click += new System.EventHandler(this.Host_button_Click);
            // 
            // open_connect_config
            // 
            this.open_connect_config.Location = new System.Drawing.Point(216, 66);
            this.open_connect_config.Name = "open_connect_config";
            this.open_connect_config.Size = new System.Drawing.Size(75, 23);
            this.open_connect_config.TabIndex = 3;
            this.open_connect_config.Text = "Config";
            this.open_connect_config.UseVisualStyleBackColor = true;
            this.open_connect_config.Click += new System.EventHandler(this.open_connect_config_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(216, 112);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Config";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(216, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Config";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // SPChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(318, 247);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.open_connect_config);
            this.Controls.Add(this.Host_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ConnectServer_button);
            this.Name = "SPChat";
            this.Text = "SPChat";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ConnectServer_button;
        private Button button2;
        private Button Host_button;
        private Button open_connect_config;
        private Button button5;
        private Button button6;
    }
}