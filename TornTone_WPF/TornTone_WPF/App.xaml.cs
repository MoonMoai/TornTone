using System.Configuration;
using System.Data;
using System.Windows;
using TornTone_WPF.UI;
using TornTone_WPF.VM;

namespace TornTone_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private MainWindow _mainWindow;
        private MainWindowVM _mainWindowVM;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            _mainWindowVM = new MainWindowVM();
            _mainWindow = new MainWindow(_mainWindowVM);

            _mainWindow.Show();
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {

        }
    }

}
