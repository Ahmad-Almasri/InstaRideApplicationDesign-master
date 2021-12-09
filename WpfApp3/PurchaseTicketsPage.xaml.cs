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
    /// Interaction logic for PurchaseTicketsPage.xaml
    /// </summary>
    public partial class PurchaseTicketsPage : Page
    {
        public PurchaseTicketsPage()
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
                cost.Visibility = Visibility.Visible;
            }
            else
            {
                SP3.Height -= 440;
                TBPress.Visibility = Visibility.Visible;
                cost.Visibility = Visibility.Hidden;
            }
        }

        private void AdultTickets(object sender, MouseButtonEventArgs e)
        {
            if (SPA.Height == 50)
            {
                SPA.Height = 200;
            }
            else
            {
                SPA.Height = 50;
            }
        }

        private void YouthTickets(object sender, MouseButtonEventArgs e)
        {
            if (SPY.Height == 50)
            {
                SPY.Height = 200;
                SPA.Visibility = Visibility.Collapsed;
            }
            else
            {
                SPY.Height = 50;
                SPA.Visibility = Visibility.Visible;
            }
        }

        private void SeniorTickets(object sender, MouseButtonEventArgs e)
        {
            if (SPS.Height == 50)
            {
                SPS.Height = 200;
                SPA.Visibility = Visibility.Collapsed;
                SPY.Visibility = Visibility.Collapsed;
            }
            else
            {
                SPS.Height = 50;
                SPA.Visibility = Visibility.Visible;
                SPY.Visibility = Visibility.Visible;
            }
        }

        private void backBtn(object sender, MouseButtonEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new AddOptionsPage());
        }

        private void paymentBtn(object sender, RoutedEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            string currentValue = value.Text;
            long theIntegerValue = Int64.Parse(currentValue);
            string initialValue = valueDailyAdult.Text;
            long theIntValue = Int64.Parse(initialValue);

            string currentValue2 = valueYouth.Text;
            long theIntegerValue2 = Int64.Parse(currentValue2);
            string initialValue2 = dailyYouth.Text;
            long theIntValue2 = Int64.Parse(initialValue2);

            string currentValue3 = valueSenior.Text;
            long theIntegerValue3 = Int64.Parse(currentValue3);
            string initialValue3 = dailySenior.Text;
            long theIntValue3 = Int64.Parse(initialValue3);

            if(theIntegerValue > 0 || theIntValue > 0 || theIntegerValue2 > 0 || theIntValue2 > 0 || theIntegerValue3 > 0 || theIntValue3 > 0)
                nav.Navigate(new PaymentOptionsPage());
        }
        //All 4 adult buttons
        private void addAmount(object sender, RoutedEventArgs e)
        {
            string currentValue = value.Text;
            long theIntegerValue = Int64.Parse(currentValue);
            theIntegerValue += 1;
            string theFinalValue = theIntegerValue.ToString();
            value.Text = theFinalValue;
            cost.Text = "Cost 3.30$";
        }
        private void reduceAmount(object sender, RoutedEventArgs e)
        {
            string currentValue = value.Text;
            long theIntegerValue = Int64.Parse(currentValue);
            if(theIntegerValue >0)
                theIntegerValue -= 1;
            string theFinalValue = theIntegerValue.ToString();
            value.Text = theFinalValue;
        }
        private void addDailyAdult(object sender, RoutedEventArgs e)
        {
            string initialValue = valueDailyAdult.Text;
            long theIntValue = Int64.Parse(initialValue);
            theIntValue += 1;
            string finalValue = theIntValue.ToString();
            valueDailyAdult.Text = finalValue;
        }
        private void reduceDailyAdult(object sender, RoutedEventArgs e)
        {
            string currentValue = valueDailyAdult.Text;
            long theIntegerValue = Int64.Parse(currentValue);
            if (theIntegerValue > 0)
                theIntegerValue -= 1;
            string theFinalValue = theIntegerValue.ToString();
            valueDailyAdult.Text = theFinalValue;
        }
        //All 4 youth buttons
        private void addYouthAmount(object sender, RoutedEventArgs e)
        {
            string currentValue = valueYouth.Text;
            long theIntegerValue = Int64.Parse(currentValue);
            theIntegerValue += 1;
            string theFinalValue = theIntegerValue.ToString();
            valueYouth.Text = theFinalValue;
        }
        private void reduceYouthAmount(object sender, RoutedEventArgs e)
        {
            string currentValue = valueYouth.Text;
            long theIntegerValue = Int64.Parse(currentValue);
            if (theIntegerValue > 0)
                theIntegerValue -= 1;
            string theFinalValue = theIntegerValue.ToString();
            valueYouth.Text = theFinalValue;
        }
        private void addDailyYouth(object sender, RoutedEventArgs e)
        {
            string initialValue = dailyYouth.Text;
            long theIntValue = Int64.Parse(initialValue);
            theIntValue += 1;
            string finalValue = theIntValue.ToString();
            dailyYouth.Text = finalValue;
        }
        private void reduceDailyYouth(object sender, RoutedEventArgs e)
        {
            string currentValue = dailyYouth.Text;
            long theIntegerValue = Int64.Parse(currentValue);
            if (theIntegerValue > 0)
                theIntegerValue -= 1;
            string theFinalValue = theIntegerValue.ToString();
            dailyYouth.Text = theFinalValue;
        }
        //All 4 senior buttons
        private void addSeniorAmount(object sender, RoutedEventArgs e)
        {
            string currentValue = valueSenior.Text;
            long theIntegerValue = Int64.Parse(currentValue);
            theIntegerValue += 1;
            string theFinalValue = theIntegerValue.ToString();
            valueSenior.Text = theFinalValue;
        }
        private void reduceSeniorAmount(object sender, RoutedEventArgs e)
        {
            string currentValue = valueSenior.Text;
            long theIntegerValue = Int64.Parse(currentValue);
            if (theIntegerValue > 0)
                theIntegerValue -= 1;
            string theFinalValue = theIntegerValue.ToString();
            valueSenior.Text = theFinalValue;
        }
        private void addDailySenior(object sender, RoutedEventArgs e)
        {
            string initialValue = dailySenior.Text;
            long theIntValue = Int64.Parse(initialValue);
            theIntValue += 1;
            string finalValue = theIntValue.ToString();
            dailySenior.Text = finalValue;
        }
        private void reduceDailySenior(object sender, RoutedEventArgs e)
        {
            string currentValue = dailySenior.Text;
            long theIntegerValue = Int64.Parse(currentValue);
            if (theIntegerValue > 0)
                theIntegerValue -= 1;
            string theFinalValue = theIntegerValue.ToString();
            dailySenior.Text = theFinalValue;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new WalletPage());
        }
    }
}
