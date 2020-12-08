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
    /// Логика взаимодействия для admin_win.xaml
    /// </summary>
    public partial class admin_win : Window
    {
        public admin_win()
        {
            InitializeComponent();
            fio_lbl.Content = global_users.user_name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow close = new MainWindow();
            close.Show();
            this.Hide();
        }
    }
}
