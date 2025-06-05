using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TornTone_WPF.UI.Navigation
{
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnTakePhoto_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoForward) // 뒤로가기 이후 다시 페이지 들어가는 경우
            {
                NavigationService.GoForward();
            }
            else
            {
                TakePhotoPage takePhotoPage = new TakePhotoPage();
                NavigationService.Navigate(takePhotoPage);
            }  
        }

        private void btnHistory_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
            else
            {
                HistoryPage historyPage = new HistoryPage();
                NavigationService.Navigate(historyPage);
            }
        }
    }
}
