namespace SPChat
{
    public partial class SPChat : Form
    {
        public HostFunc.Forms.ServerForm serverform;
        public SPChat()
        {
            InitializeComponent();
        }



        private void open_connect_config_Click(object sender, EventArgs e)
        {
           Configuration.Forms.SPCHAT_connect_conf_form connect_form = new Configuration.Forms.SPCHAT_connect_conf_form();

           // form2.StartPosition = FormStartPosition.Manual; // TODO
           //  form2.Left = 500;
           //  form2.Top = 500;

            connect_form.ShowDialog();
        }

      

        private void ConnectServer_button_Click(object sender, EventArgs e)
        {
            ConnectionFunc.Forms.ConnectionForm ConnectionForm = new ConnectionFunc.Forms.ConnectionForm();
            ConnectionForm.Show();
        }

        private void Host_button_Click(object sender, EventArgs e)
        {
             serverform = new HostFunc.Forms.ServerForm();
            //chatform.ShowDialog();
            serverform.Show();

        }

     
    }
}