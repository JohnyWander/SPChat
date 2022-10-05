namespace SPChat.Configuration.Forms
{
    partial class SPCHAT_connect_conf_form
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
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColorMode = new System.Windows.Forms.CheckBox();
            this.rgb_input = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ChooseColor_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeOfConnection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet"});
            this.ColorComboBox.Location = new System.Drawing.Point(21, 52);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(121, 23);
            this.ColorComboBox.TabIndex = 0;
            this.ColorComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client chat color";
            // 
            // ColorMode
            // 
            this.ColorMode.AutoSize = true;
            this.ColorMode.Checked = true;
            this.ColorMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ColorMode.Location = new System.Drawing.Point(21, 27);
            this.ColorMode.Name = "ColorMode";
            this.ColorMode.Size = new System.Drawing.Size(158, 19);
            this.ColorMode.TabIndex = 2;
            this.ColorMode.Text = "Use pre-definied/custom";
            this.ColorMode.UseVisualStyleBackColor = true;
            this.ColorMode.CheckedChanged += new System.EventHandler(this.changed_ColorMode);
            // 
            // rgb_input
            // 
            this.rgb_input.Enabled = false;
            this.rgb_input.Location = new System.Drawing.Point(-90, 216);
            this.rgb_input.Name = "rgb_input";
            this.rgb_input.Size = new System.Drawing.Size(100, 23);
            this.rgb_input.TabIndex = 3;
            this.rgb_input.Text = "RGB - 0;0;0";
            this.rgb_input.Visible = false;
            this.rgb_input.Click += new System.EventHandler(this.rgb_input_remove_placeholder);
            // 
            // ChooseColor_button
            // 
            this.ChooseColor_button.Enabled = false;
            this.ChooseColor_button.Location = new System.Drawing.Point(148, 52);
            this.ChooseColor_button.Name = "ChooseColor_button";
            this.ChooseColor_button.Size = new System.Drawing.Size(123, 23);
            this.ChooseColor_button.TabIndex = 4;
            this.ChooseColor_button.Text = "Choose Color";
            this.ChooseColor_button.UseVisualStyleBackColor = true;
            this.ChooseColor_button.Visible = false;
            this.ChooseColor_button.Click += new System.EventHandler(this.Choose_color_button);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 2);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type of connection";
            // 
            // TypeOfConnection
            // 
            this.TypeOfConnection.FormattingEnabled = true;
            this.TypeOfConnection.Items.AddRange(new object[] {
            "No Encryption",
            "RSA Without Diffie Hellman"});
            this.TypeOfConnection.Location = new System.Drawing.Point(21, 109);
            this.TypeOfConnection.Name = "TypeOfConnection";
            this.TypeOfConnection.Size = new System.Drawing.Size(158, 23);
            this.TypeOfConnection.TabIndex = 7;
            this.TypeOfConnection.SelectedIndexChanged += new System.EventHandler(this.TypeOfConnection_SelectedIndexChanged);
            // 
            // SPCHAT_connect_conf_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(319, 251);
            this.Controls.Add(this.TypeOfConnection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChooseColor_button);
            this.Controls.Add(this.rgb_input);
            this.Controls.Add(this.ColorMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorComboBox);
            this.Name = "SPCHAT_connect_conf_form";
            this.Text = "SPChat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ColorComboBox;
        private Label label1;
        private CheckBox ColorMode;
        private TextBox rgb_input;
        private ColorDialog colorDialog1;
        private Button ChooseColor_button;
        private Label label2;
        private Label label3;
        private ComboBox TypeOfConnection;
    }
}