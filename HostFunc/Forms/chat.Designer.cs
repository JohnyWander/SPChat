namespace SPChat.HostFunc.Forms
{
    partial class chat
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
            this.start_server = new System.Windows.Forms.Button();
            this.ConnectedUsersLabelText = new System.Windows.Forms.Label();
            this.ConnectedUsersCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_server
            // 
            this.start_server.Location = new System.Drawing.Point(91, 231);
            this.start_server.Name = "start_server";
            this.start_server.Size = new System.Drawing.Size(75, 23);
            this.start_server.TabIndex = 0;
            this.start_server.Text = "Start Server";
            this.start_server.UseVisualStyleBackColor = true;
            this.start_server.Click += new System.EventHandler(this.start_server_Click);
            // 
            // ConnectedUsersLabelText
            // 
            this.ConnectedUsersLabelText.AutoSize = true;
            this.ConnectedUsersLabelText.Location = new System.Drawing.Point(12, 27);
            this.ConnectedUsersLabelText.Name = "ConnectedUsersLabelText";
            this.ConnectedUsersLabelText.Size = new System.Drawing.Size(132, 15);
            this.ConnectedUsersLabelText.TabIndex = 1;
            this.ConnectedUsersLabelText.Text = "Connected users count:";
            // 
            // ConnectedUsersCounter
            // 
            this.ConnectedUsersCounter.AutoSize = true;
            this.ConnectedUsersCounter.Location = new System.Drawing.Point(139, 27);
            this.ConnectedUsersCounter.Name = "ConnectedUsersCounter";
            this.ConnectedUsersCounter.Size = new System.Drawing.Size(13, 15);
            this.ConnectedUsersCounter.TabIndex = 2;
            this.ConnectedUsersCounter.Text = "0";
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(268, 288);
            this.Controls.Add(this.ConnectedUsersCounter);
            this.Controls.Add(this.ConnectedUsersLabelText);
            this.Controls.Add(this.start_server);
            this.Name = "chat";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.xd);
            this.Load += new System.EventHandler(this.chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button start_server;
        private Label ConnectedUsersLabelText;
        private Label ConnectedUsersCounter;
    }
}