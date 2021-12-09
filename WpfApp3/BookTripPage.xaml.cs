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
    /// Interaction logic for SignUpPage.xaml
    /// </summary>
    public partial class BookTripPage : Page
    {
        public BookTripPage()
        {
            InitializeComponent();
            addDayToComboBox();
            addMonthToComboBox();
            addTimeToCmboBox();
        }

        private void addTimeToCmboBox()
        {
            int noon = 12;

            for (int i = 1; i < 24; i++)
            {
                for (int j = 0; j < 60; j += 10)
                {

                    if (i < 12)
                    {
                        if (j < 10)
                        {
                            comboBoxTime.Items.Add(i.ToString() + ":" + "0" + j.ToString() + " AM");
                        }
                        else
                        {
                            comboBoxTime.Items.Add(i.ToString() + ":" + j.ToString() + " AM");
                        }
                    }
                    else
                    {
                        if (j < 10)
                        {
                            comboBoxTime.Items.Add(noon.ToString() + ":" + "0" + j.ToString() + " PM");
                        }
                        else
                        {
                            comboBoxTime.Items.Add(noon.ToString() + ":" + j.ToString() + " PM");
                        }
                    }
                }

                if (i >= 12)
                {
                    noon++;
                }

                if (noon == 13)
                {
                    noon = 1;
                }
            }
        }

        private void addMonthToComboBox()
        {
            string[] months = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;

            foreach (string month in months) // writing out
            {
                comboBoxMonths.Items.Add(month);
            }
        }

        private void addDayToComboBox()
        {
            for (int i = 1; i <= 31; i++)
            {
                comboBoxDays.Items.Add(i);
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

            nav.Navigate(new MainOptionsPage());
        }

        private void bookTripBtn(object sender, RoutedEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new TripsPage());
        }
    }
}