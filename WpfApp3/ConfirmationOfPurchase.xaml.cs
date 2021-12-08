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
    /// Interaction logic for ConfirmationOfPurchase.xaml
    /// </summary>
    public partial class ConfirmationOfPurchase : Page
    {
        public ConfirmationOfPurchase()
        {
            InitializeComponent();
        }

        WalletPage newWindow = new WalletPage();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);
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
            //myBorder1.Background = Brushes.DarkBlue;
            var bc = new BrushConverter();

            myBorder1.Background = (Brush)bc.ConvertFrom("#FF1C54C2");
            //myBorder1.BorderBrush = Brushes.Black;
            myBorder1.BorderThickness = new Thickness(1);
            myBorder1.CornerRadius = new CornerRadius(25);
            TextBlock txt1 = new TextBlock();
            txt1.Foreground = Brushes.White;
            txt1.FontSize = 15;
            txt1.Text = "              Ticket 3 \n " +
                "                                                                            Activate \n" +
                "            Expires in : 7 Days ";
            myBorder1.Child = txt1;
            newWindow.sp1.Children.Add(myBorder1);

        }
    }
}
