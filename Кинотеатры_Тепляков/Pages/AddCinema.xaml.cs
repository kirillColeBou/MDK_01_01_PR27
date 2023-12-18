using MySql.Data.MySqlClient;
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

namespace Кинотеатры_Тепляков.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddCinema.xaml
    /// </summary>
    public partial class AddCinema : Page
    {
        public static AddCinema addCinema;
        public AddCinema()
        {
            InitializeComponent();
            addCinema = this;
        }

        private void AddNewCinema_db(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = Classes.Connection.DBConnection.OpenConnection();
            Classes.Connection.DBConnection.Query($"INSERT INTO Cinemas.cinema (name_cinema, count_hall, count_place) VALUES ('{tb_name.Text}', '{Convert.ToInt32(tb_count_hall.Text)}', '{Convert.ToInt32(tb_count_place.Text)}')", connection);
            Classes.Connection.DBConnection.CloseConnection(connection);
            MainWindow.init.OpenPages(MainWindow.pages.cinema);
        }

        private void BackPage(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(MainWindow.pages.cinema);
        }
    }
}
