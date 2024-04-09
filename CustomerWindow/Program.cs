using log4net;
using RestaurantFrontEnd;
using System.Security.Principal;

namespace CustomerWindow
{
    internal static class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                WindowsPrincipal principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
                string username = principal.Identity.Name;
            }
            catch (Exception credE) {
                log.Error(credE.Message); 
            }
            Application.Run(new RestaurantsMainWindow());
        }
    }
}