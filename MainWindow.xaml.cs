using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace exam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            all_users = core.DB.users.ToList();
        }
        public List<users> all_users { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tb_login.Text != "" && pb_login.Password != "")
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-4F2BDOND\SQLEXPRESS;Initial Catalog=exambd;Integrated Security=True");
                sqlcon.Open();
                string query = "SELECT * FROM users WHERE login=@u_login and password=@u_pass";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.Add(new SqlParameter("u_login", tb_login.Text));
                cmd.Parameters.Add(new SqlParameter("u_pass", pb_login.Password));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    global_users.user_name = dt.Rows[0]["name"].ToString();
                    role_win open = new role_win();
                    open.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
    }
}
