using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPChat.Configuration
{
    internal class ConnectServer_config 
    {
        public ConnectServer_config()
        {

            Configuration.Forms.SPCHAT_connect_conf_form con_conf_form = new Configuration.Forms.SPCHAT_connect_conf_form();
            con_conf_form.ShowDialog();
        }

    }
}
