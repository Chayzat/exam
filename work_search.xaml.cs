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
    /// Логика взаимодействия для work_search.xaml
    /// </summary>
    public partial class work_search : Window
    {
        public work_search()
        {
            InitializeComponent();
            DataContext = this;
            all_reports = core.DB.reports.ToList();
        }
        public List<reports> all_reports { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            laborant_search back = new laborant_search();
            back.Show();
            this.Hide();
        }
    }
}
