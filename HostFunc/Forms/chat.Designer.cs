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
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(268, 288);
            this.Controls.Add(this.start_server);
            this.Name = "chat";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.xd);
            this.Load += new System.EventHandler(this.chat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button start_server;
    }
}