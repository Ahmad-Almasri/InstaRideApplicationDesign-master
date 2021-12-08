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
    public partial class SignUpPage : Page
    {
        public SignUpPage()
        {
            InitializeComponent();
            addDayToComboBox();
            addMonthToComboBox();
            addYearToCmboBox();
        }

        private void addYearToCmboBox()
        {
            for (int i = 2004; i >= 1950; i--)
            {
                comboBoxYears.Items.Add(i);
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

        private void comboBoxMonths_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
