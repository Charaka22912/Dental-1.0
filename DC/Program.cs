using System.Data.SqlClient;
namespace DC
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());


        }
        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            // Perform cleanup or additional tasks before the application exits
        }
    }
}