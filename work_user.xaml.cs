using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
    /// Логика взаимодействия для work_user.xaml
    /// </summary>
    public partial class work_user : Window
    {
        SqlConnection connectionString = new SqlConnection(@"Data Source=LAPTOP-4F2BDOND\SQLEXPRESS;Initial Catalog=exambd;Integrated Security=True");
        public work_user()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            laborant_win back = new laborant_win();
            back.Show();
            this.Hide();
        }
        string fname = "";
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            SaveFileDialog sfd = new SaveFileDialog();
            if (ofd.ShowDialog() == true)
            {
                fname = ofd.FileName;

            }
          
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-4F2BDOND\SQLEXPRESS;Initial Catalog=exambd;Integrated Security=True"))
            {
                DateTime thisDay = DateTime.Now;
                byte[] docs = null;
                FileStream Streem = new FileStream(fname, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Streem);
                docs = brs.ReadBytes((int)Streem.Length);
                sqlCon.Open();
                string str = "INSERT INTO reports(name, date, path,report_file,result) VALUES ('" + tb_name.Text
                   + "','" + thisDay.ToString() + "','" +fname+"','"+fname + "',@docs'" + tb_result.Text+"';')";
                SqlCommand comm = new SqlCommand(str, sqlCon);
                comm.Parameters.Add(new SqlParameter("@docs", docs));
                comm.ExecuteNonQuery();
                MessageBox.Show("успешно добавлен!");
            }
        }
    }
}
