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
    /// Interaction logic for MapPage.xaml
    /// </summary>
    public partial class MapPage : Page
    {
        public MapPage()
        {
            InitializeComponent();

            
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

        private void btnBack(object sender, MouseButtonEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new MainOptionsPage());
        }

        private void BtnClickM1(object sender, MouseButtonEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new AddOptionsPage());
        }

        private void GetRoutes_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StartLocation.Text) || string.IsNullOrWhiteSpace(EndLocation.Text))
            {
                return;
            }

            var startLocation = StartLocation.Text.Replace(' ', '+');
            var endLocation = EndLocation.Text.Replace(' ', '+');

            var apiKey = "AIzaSyBBrE-3pg2ErqlMU-xzFmnzt-tn6d2bQeU";
            var url = $"https://maps.googleapis.com/maps/api/directions/json?origin={startLocation}&destination={endLocation}&key={apiKey}";
            var url1 = $"https://maps.googleapis.com/maps/dir/{startLocation}/{endLocation}";

            var a = "https://www.google.com/maps/dir/CF+Market+Mall,+3625+Shaganappi+Trail+NW,+Calgary,+AB+T3A+0E2/CF+Chinook+Centre,+6455+Macleod+Trail,+Calgary,+AB+T2H+0K8/@51.0440725,-114.1842072,12z/data=!3m1!4b1!4m14!4m13!1m5!1m1!1s0x53716f1dd552d43f:0x929f85129c2c11d3!2m2!1d-114.1554!2d51.0845495!1m5!1m1!1s0x537170558c817a7b:0xa80ab79074859579!2m2!1d-114.0733449!2d50.9984961!3e3";


            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new ShowMap(StartLocation.Text, EndLocation.Text, a));
        }

        private void GetRoutes_Click(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
