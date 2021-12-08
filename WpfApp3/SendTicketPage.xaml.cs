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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for SendTicketPage.xaml
    /// </summary>
    public partial class SendTicketPage : Page
    {
        public SendTicketPage()
        {
            InitializeComponent();
        }

        private void btnBack(object sender, MouseButtonEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new WalletPage());
        }

        int temp = 0;
        int temp2 = 0;
        int temp3 = 0;
        private void choseOptionOne(object sender, MouseButtonEventArgs e)
        {
            if(temp == 0)
            {
                temp = 1;
                selectFirst.Foreground = Brushes.Black;
            }
            else
            {
                temp = 0;
                selectFirst.Foreground = Brushes.White;
            }

        }

        private void choseOptionTwo(object sender, MouseButtonEventArgs e)
        {
            if (temp2 == 0)
            {
                temp2 = 1;
                selectSecond.Foreground = Brushes.Black;
            }
            else
            {
                temp2 = 0;
                selectSecond.Foreground = Brushes.White;
            }
        }

        private void choseOptionThree(object sender, MouseButtonEventArgs e)
        {
            if (temp3 == 0)
            {
                temp3 = 1;
                selectThird.Foreground = Brushes.Black;
            }
            else
            {
                temp3 = 0;
                selectThird.Foreground = Brushes.White;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            if(temp != 0 || temp2!= 0 || temp3 != 0)
                nav.Navigate(new sendTicketComfirmationPage());
        }
    }
}
