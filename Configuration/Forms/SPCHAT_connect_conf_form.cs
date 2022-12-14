using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace SPChat.Configuration.Forms
{
    public partial class SPCHAT_connect_conf_form : Form
    {
        public SPCHAT_connect_conf_form()
        {
            InitializeComponent();
            string forset;
            ConfigManipulator.ConnectionConf_GetConfig(ConfigManipulator.ConnectionConfPools.ConnectionScheme, out forset);
            this.TypeOfConnection.SelectedIndex = this.TypeOfConnection.Items.IndexOf(forset);
            MessageBox.Show(forset);
        }

       public void changed_ColorMode(object sender,object args)
        {
            
            if (this.ColorMode.Checked)
            {
                this.ColorComboBox.Visible = true;
                this.ColorComboBox.Enabled = true;

               
                this.rgb_input.Visible = false;
                this.rgb_input.Enabled = false;

                this.ChooseColor_button.Enabled = false;
                this.ChooseColor_button.Visible = false;


            }

            if(!this.ColorMode.Checked)
            {
                this.ColorComboBox.Visible = false;
                this.ColorComboBox.Enabled = false;

                Point insert_location =  this.ColorComboBox.Location;

                this.rgb_input.Location = insert_location;
                this.rgb_input.Width = this.ColorComboBox.Width;
                this.rgb_input.Visible = true;
                this.rgb_input.Enabled = false;

                this.ChooseColor_button.Enabled = true;
                this.ChooseColor_button.Visible = true;


                
               // MessageBox.Show(selected.ToArgb().ToString());
                
               




            }
        }


     
        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rgb_input.Text = this.ColorComboBox.SelectedItem.ToString();
            Configuration.ConfigManipulator.ConnectionConf_ChangeConfig(ConfigManipulator.ConnectionConfPools.ClientChatColor, this.rgb_input.Text);
        }

        private void rgb_input_remove_placeholder(object sender, EventArgs e)
        {
            
            if(this.rgb_input.Text=="RGB - 0;0;0")
            {
                this.rgb_input.Text = "";
            }

        }

        private void Choose_color_button(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            Color selected = colorDialog1.Color;
            this.rgb_input.Text = "ARGB - " + selected.A + ";" + selected.R + ";" + selected.G + ";" + selected.B;
            Configuration.ConfigManipulator.ConnectionConf_ChangeConfig(ConfigManipulator.ConnectionConfPools.ClientChatColor,this.rgb_input.Text);

        }

        private void TypeOfConnection_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigManipulator.ConnectionConf_ChangeConfig(ConfigManipulator.ConnectionConfPools.ConnectionScheme,this.TypeOfConnection.SelectedItem.ToString());
        }
    }
}
