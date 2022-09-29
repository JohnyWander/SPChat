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


    public static void start_server()
        {

            Thread server = new Thread(() =>
            {
                HostFunc.HOST server = new HostFunc.HOST();
            });
            server.IsBackground = true;
            server.Start();
        }

    public static void start_connection(string ip, string port )
        {
            Thread connection = new Thread(() =>
            {
                ConnectionFunc.CONNECTION connection = new ConnectionFunc.CONNECTION(ip,port);
            });
            connection.IsBackground = true;
            connection.Start();

        }






    }
}