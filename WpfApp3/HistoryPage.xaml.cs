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
    /// Interaction logic for HistoryPage.xaml
    /// </summary>
    public partial class HistoryPage : Page
    {
        public HistoryPage()
        {
            InitializeComponent();
            if (Status.x == 0) // we have no active tickets
            {
                atTextBox.Text = Status.x + " Active Ticket";

            }
            else if (Status.x == 1)
            { // we have 1 active ticket
                atTextBox.Text = Status.x + " Active Ticket";
                firstTicket.Visibility = Visibility.Visible;
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

        private void backBtn(object sender, MouseButtonEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new WalletPage());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new WalletPage());
        }
    }
}
