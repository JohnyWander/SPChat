using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPChat.Configuration.Forms
{
    public partial class SPCHAT_connect_conf_form : Form
    {
        public SPCHAT_connect_conf_form()
        {
            InitializeComponent();
        }

       public void changed_ColorMode(object sender,object args)
        {
            
            if (this.ColorMode.Checked)
            {
                this.ColorComboBox.Visible = true;
                this.ColorComboBox.Enabled = true;

               
                this.rgb_input.Visible = false;
                this.rgb_input.Enabled = false;
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

                this.colorDialog1.ShowDialog();
                Color selected = colorDialog1.Color;
               // MessageBox.Show(selected.ToArgb().ToString());
                
                this.rgb_input.Text = "ARGB - " + selected.A + ";" + selected.R+";" + selected.G + ";" + selected.B;




            }
        }

        private void rgb_input_remove_placeholder(object sender, EventArgs e)
        {
            
            if(this.rgb_input.Text=="RGB - 0;0;0")
            {
                this.rgb_input.Text = "";
            }

        }
    }
}
