using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace wpf_demo_app
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            wnd.Title = "Démarrage en code-behind";

            if (e.Args.Length > 0)
            {
                // Gérer les paramètres ici
                wnd.Message = e.Args[0];
            }
            
            wnd.Show();
        }
    }
}
