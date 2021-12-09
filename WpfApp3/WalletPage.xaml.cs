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
    /// Interaction logic for WalletPage.xaml
    /// </summary>
    public partial class WalletPage : Page
    {
        public WalletPage()
        {
            InitializeComponent();

            if (Status.x == 1)
            {
                ticTitle.Text = "Activated Ticket";
                btnAct.Visibility = Visibility.Hidden;
                atTextBox.Text = "1 Active Ticket";
            }

            if (Status.x == 0) {
                ticket1.Visibility = Visibility.Hidden;
            }

            if (Status.y == -1) {
                ticket1.Visibility = Visibility.Visible; 
            }
        }

        private void ActiveTicketDown(object sender, MouseButtonEventArgs e)
        {
            if (SP3.Height == 45)
            {
                SP3.Height += 440;
                TBPress.Visibility = Visibility.Hidden;
            }
            else
            {
                SP3.Height -= 440;
                TBPress.Visibility = Visibility.Visible;
            }
        }

        private void sendTicketBtn(object sender, RoutedEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new SendTicketPage());
        }

        private void historyBtn(object sender, RoutedEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new HistoryPage());
        }

        private void btnBack(object sender, MouseButtonEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new MainOptionsPage());
        }

        private void addFundsBtn(object sender, RoutedEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new AddFundsPage());
        }

        private void Act(object sender, RoutedEventArgs e)
        {
            // Status.ticket1Status = 1;
            Status.x = 1;
            var nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new MainOptionsPage());
        }
        


    }
}
