using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TornTone_WPF.VM;
using Wpf.Ui.Appearance;

namespace TornTone_WPF.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVM _mainWindowVM;
        public MainWindow(MainWindowVM mainWindowVM)
        {
            InitializeComponent();
            ApplicationThemeManager.Apply(this);

            _mainWindowVM = mainWindowVM;
            this.DataContext = _mainWindowVM;
        }
    }
}