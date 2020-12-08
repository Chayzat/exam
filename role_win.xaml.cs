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
using System.Windows.Shapes;

namespace exam
{
    /// <summary>
    /// Логика взаимодействия для role_win.xaml
    /// </summary>
    public partial class role_win : Window
    {
        public role_win()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            laborant_win open = new laborant_win();
            open.Show();
            this.Hide();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            laborant_search open = new laborant_search();
            open.Show();
            this.Hide();
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            econ_win open = new econ_win();
            open.Show();
            this.Hide();
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            admin_win open = new admin_win();
            open.Show();
            this.Hide();
        }
    }
}
