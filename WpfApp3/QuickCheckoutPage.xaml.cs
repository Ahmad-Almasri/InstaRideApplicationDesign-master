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
    /// Interaction logic for QuickCheckoutPage.xaml
    /// </summary>
    public partial class QuickCheckoutPage : Page
    {
        public QuickCheckoutPage()
        {
            InitializeComponent();
        }


        private void btnBack(object sender, MouseButtonEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new MainOptionsPage());
        }

        int temp = 0;
        int temp2 = 0;
        int temp3 = 0;
        private void choseOptionOne(object sender, MouseButtonEventArgs e)
        {
            if(temp == 0)
            {
                temp = 1;
                temp2 = 0;
                temp3 = 0;
                selectFirst.Fill = Brushes.Green;
                selectSecond.Fill = Brushes.White;
                selectThird.Fill = Brushes.White;
            }
            else if(temp == 1)
            {
                temp = 0;
                selectFirst.Fill = Brushes.White;
                selectSecond.Fill = Brushes.White;
                selectThird.Fill = Brushes.White;
            }

        }

        private void choseOptionTwo(object sender, MouseButtonEventArgs e)
        {
            if(temp2 == 0)
            {
                temp2 = 1;
                temp = 0;
                temp3 = 0;
                selectFirst.Fill = Brushes.White;
                selectSecond.Fill = Brushes.Green;
                selectThird.Fill = Brushes.White;
            }
            else if (temp2 == 1)
            {
                temp2 = 0;

                selectFirst.Fill = Brushes.White;
                selectSecond.Fill = Brushes.White;
                selectThird.Fill = Brushes.White;
            }

        }

        private void choseOptionThree(object sender, MouseButtonEventArgs e)
        {
            if(temp3 == 0)
            {
                temp3 = 1;
                temp2 = 0;
                temp = 0;
                selectFirst.Fill = Brushes.White;
                selectSecond.Fill = Brushes.White;
                selectThird.Fill = Brushes.Green;
            }
            else if (temp3 == 1)
            {
                temp3 = 0;
                selectFirst.Fill = Brushes.White;
                selectSecond.Fill = Brushes.White;
                selectThird.Fill = Brushes.White;
            }

        }

        WalletPage newWindow = new WalletPage();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);
            // Status.ticket2Status = 1;
            // Status.ticketTwoInBarStatus = 1;
            Status.x = 1;
            nav.Navigate(new WalletPage());
            /*
            Status.x = 1;
            nav.Navigate(newWindow);

            if(temp == 1)
            {
                Border myBorder1 = new Border();
                myBorder1.Height = 80;
                myBorder1.Width = 420;
                Thickness margin = myBorder1.Margin;
                margin.Left = 5;
                margin.Top = 20;
                margin.Right = 5;
                margin.Bottom = 0;
                myBorder1.Margin = margin;
                var bc = new BrushConverter();

                myBorder1.Background = (Brush)bc.ConvertFrom("#FF1C54C2");
                myBorder1.BorderThickness = new Thickness(1);
                myBorder1.CornerRadius = new CornerRadius(25);
                TextBlock txt1 = new TextBlock();
                txt1.Foreground = Brushes.White;
                txt1.FontSize = 15;
                txt1.Text = "       1 Adult Ticket \n " +
                    "                                                                            Activated \n" +
                    "        Expires in : 2 hours ";
                myBorder1.Child = txt1;
                newWindow.sp1.Children.Add(myBorder1);
            }
            else if(temp2 == 1)
            {
                Border myBorder1 = new Border();
                myBorder1.Height = 80;
                myBorder1.Width = 420;
                Thickness margin = myBorder1.Margin;
                margin.Left = 5;
                margin.Top = 20;
                margin.Right = 5;
                margin.Bottom = 0;
                myBorder1.Margin = margin;
                var bc = new BrushConverter();

                myBorder1.Background = (Brush)bc.ConvertFrom("#FF1C54C2");
                myBorder1.BorderThickness = new Thickness(1);
                myBorder1.CornerRadius = new CornerRadius(25);
                TextBlock txt1 = new TextBlock();
                txt1.Foreground = Brushes.White;
                txt1.FontSize = 15;
                txt1.Text = "       1 Youth Ticket \n " +
                    "                                                                            Activated \n" +
                    "        Expires in : 2 hours ";
                myBorder1.Child = txt1;
                newWindow.sp1.Children.Add(myBorder1);
            }
            else if(temp3 == 1)
            {
                Status.ticket2Status = 1;
                Status.ticketTwoInBarStatus = 1;
                Border myBorder1 = new Border();
                myBorder1.Height = 80;
                myBorder1.Width = 420;
                Thickness margin = myBorder1.Margin;
                margin.Left = 5;
                margin.Top = 20;
                margin.Right = 5;
                margin.Bottom = 0;
                myBorder1.Margin = margin;
                myBorder1.Background = Brushes.White;
                myBorder1.BorderThickness = new Thickness(1);
                myBorder1.CornerRadius = new CornerRadius(25);
                TextBlock txt1 = new TextBlock();
                txt1.Foreground = Brushes.Blue;
                txt1.FontSize = 15;
                txt1.Text = "       1 Senior Ticket \n " +
                    "                                                                            Activated \n" +
                    "        Expires in : 2 hours ";
                myBorder1.Child = txt1;
                newWindow.sp1.Children.Add(myBorder1);
            }
        }
            */
        }
    }
}
