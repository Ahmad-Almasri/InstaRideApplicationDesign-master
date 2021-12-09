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
    /// Interaction logic for RedeemTicket.xaml
    /// </summary>
    public partial class RedeemTicket : Page
    {
        public RedeemTicket()
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

        private void btnBack(object sender, MouseButtonEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new AddOptionsPage());
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

        WalletPage newWindow = new WalletPage();
        private void goRedeem(object sender, RoutedEventArgs e)
        {
            
            var nav = NavigationService.GetNavigationService(this);
            string theInputCode = CodeTB.Text;
            if(theInputCode.Length == 10)
            {
                nav.Navigate(newWindow);

                Border myBorder1 = new Border();
                myBorder1.Height = 80;
                myBorder1.Width = 420;
                Thickness margin = myBorder1.Margin;
                margin.Left = 5;
                margin.Top = -400;
                margin.Right = 5;
                margin.Bottom = 0;
                myBorder1.Margin = margin;
                myBorder1.Background = Brushes.White;
                myBorder1.BorderBrush = Brushes.Black;
                myBorder1.BorderThickness = new Thickness(1);
                myBorder1.CornerRadius = new CornerRadius(25);
                TextBlock txt1 = new TextBlock();
                txt1.Foreground = Brushes.Blue;
                txt1.FontSize = 15;
                txt1.Text = "              Ticket 3 \n " +
                    "                                                                            Activated \n" +
                    "            Expires in : 2 hours ";
                myBorder1.Child = txt1;
                newWindow.sp1.Children.Add(myBorder1);
            }

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new WalletPage());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

            var nav = NavigationService.GetNavigationService(this);
            Status.y = -1;
            nav.Navigate(new WalletPage());
        }
    }
}
