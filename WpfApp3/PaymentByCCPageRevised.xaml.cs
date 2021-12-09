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
    /// Interaction logic for PaymentByCCPageRevised.xaml
    /// </summary>
    public partial class PaymentByCCPageRevised : Page
    {
        private int counter = 0;

        public PaymentByCCPageRevised()
        {
            InitializeComponent();
            if (Status.ticketInBarStatus == 1)
            {
                atTextBox.Text = "1 Active ticket";
                firstTicket.Visibility = Visibility.Visible;
            }
            if (Status.ticketTwoInBarStatus == 1)
            {
                secondTicket.Visibility = Visibility.Visible;
            }
            if (Status.ticketInBarStatus == 1 && Status.ticketTwoInBarStatus == 1)
            {
                atTextBox.Text = "2 Active tickets";
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

            nav.Navigate(new PaymentOptionsPage());
        }

        private void CheckBoxClicked(object sender, RoutedEventArgs e)
        {
            counter++;
            if (counter % 2 == 0)
            {
                check.IsChecked = false;
            }
        }

        private void confirmBtnRevised(object sender, RoutedEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            string emailTextBox = EmailTBox.Text;
            string cardNumberTextBox = cardNumberTB.Text;
            string monthYearTextBox = monthYearTB.Text;
            string ccvTextBox = ccvTB.Text;

            if (emailTextBox.Length >= 11 && cardNumberTextBox.Length == 16 && monthYearTextBox.Length == 4 && ccvTextBox.Length == 3)
                nav.Navigate(new ConfirmationButtonRevised());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new WalletPage());
        }
    }
}
