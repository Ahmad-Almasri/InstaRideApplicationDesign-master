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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        public Settings()
        {
            InitializeComponent();
            addThemes();
            addFontSize();
            addUM();
            addLangue();
        }

        private void backBtn(object sender, MouseButtonEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new MainOptionsPage());
        }

        private void addThemes()
        {
            string[] themes = { "Dark", "Light", "Yellow light", "Read mode"};

            foreach (string theme in themes) // writing out
            {
                comboBoxThemes.Items.Add(theme);
            }
        }
        private void addFontSize()
        {
            int[] sizes = { 5,6,8,10,12,14,16,18,20,22,24,26,30};

            foreach (int size in sizes) // writing out
            {
                comboBoxFontSize.Items.Add(size);
            }
        }
        private void addUM()
        {
            string[] unitMeas = { "Imperial","Metric"};

            foreach (string unit in unitMeas) // writing out
            {
                comboBoxUM.Items.Add(unit);
            }
        }

        private void addLangue()
        {
            string[] langues = { "English", "French", "Chinese", "Spanish"};

            foreach (string langue in langues) // writing out
            {
                comboBoxLangue.Items.Add(langue);
            }
        }
    }
}
