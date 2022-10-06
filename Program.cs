namespace SPChat
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Initialization.CheckFiles.run();
            
            ApplicationConfiguration.Initialize();
            Application.Run(new SPChat());
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
        }
        /// <summary>
        /// /// DELEGATES FOR GUI
        /// </summary>
        public static Predicate<string> Disconnect_delegate;
        // public delegate bool Disconnect_delegate();

        public static Predicate<string> StopServer_delegate;


        //Host form delegates
        public static Action<string> AddServerLogActionDelegate;



    public static bool start_server(Func<string,bool> InsertAmountDelegate)
        {
            try
            {
                Thread server = new Thread(() =>
                {
                    HostFunc.HOST server = new HostFunc.HOST(out StopServer_delegate,InsertAmountDelegate);
                });
                server.IsBackground = true;
                server.Start();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    

    public static async Task<bool> start_connection(string ip, string port,Common.ConnectionSchemes.schemes ConnectionScheme )
        {




            ConnectionFunc.CONNECTION connection  = new ConnectionFunc.CONNECTION(out Disconnect_delegate, ConnectionScheme, ip, port);

            if (connection.connection_ok)
            {
                return true;
            }
            else
            {
                return false;
            }
                
               

                

             
               
            
        }






    }
}