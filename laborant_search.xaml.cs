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
using System.Windows.Threading;

namespace exam
{
    /// <summary>
    /// Логика взаимодействия для laborant_search.xaml
    /// </summary>
    public partial class laborant_search : Window
    {
        public laborant_search()
        {
            InitializeComponent();
            fio_lbl.Content = global_users.user_name;
            //DispatcherTimer t = new DispatcherTimer();
            //t.Interval = new TimeSpan(9000000);
            //t.Start();
            //t.Tick += new EventHandler(t_Tick);
            //void t_Tick(object sender, EventArgs e) // тут просто закрываю форму логотип
            //{
            //    Close();
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow close = new MainWindow();
            close.Show();
            this.Hide();
        }
    }
}
