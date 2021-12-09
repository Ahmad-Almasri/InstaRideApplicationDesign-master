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
    /// Interaction logic for ShowMap.xaml
    /// </summary>
    public partial class ShowMap : Page
    {

        public ShowMap(string startLocation, string endLocation, string url)
        {
            InitializeComponent();
            txtStartLocation.Text = startLocation;
            txtEndLocation.Text = endLocation;
            browser.Navigate(url);

        }

        private void backBtn(object sender, MouseButtonEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new MapPage());
        }
    }


}