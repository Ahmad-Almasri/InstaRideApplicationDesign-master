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
    /// Interaction logic for sendTicketComfirmationPage.xaml
    /// </summary>
    public partial class sendTicketComfirmationPage : Page
    {
        public sendTicketComfirmationPage()
        {
            InitializeComponent();
        }

        private void generateCode(object sender, RoutedEventArgs e)
        {
            string codeTextBox;
            Random rnd = new Random();
            Random rnd2 = new Random();
            Random rnd3 = new Random();
            Random rnd4 = new Random();

            int firstQuatret = rnd.Next(1000, 9999);
            int secondQuatret = rnd.Next(1000, 9999);
            int thirdQuatret = rnd.Next(1000, 9999);
            int fourthQuatret = rnd.Next(1000, 9999);

            codeTextBox = firstQuatret.ToString() + "-" + secondQuatret.ToString() + "-" + thirdQuatret.ToString() + "-" + fourthQuatret.ToString();
            codeTB.Text = codeTextBox;
        }

        private void btnBack(object sender, MouseButtonEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new SendTicketPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new MainOptionsPage());
        }
    }
}
