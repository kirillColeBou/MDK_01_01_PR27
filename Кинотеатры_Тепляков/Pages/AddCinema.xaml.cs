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
using Кинотеатры_Тепляков.Models;

namespace Кинотеатры_Тепляков.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddCinema.xaml
    /// </summary>
    public partial class AddCinema : Page
    {
        public Models.Cinema Cinema;
        public static AddCinema addCinema;
        public AddCinema(Models.Cinema Cinema = null)
        {
            InitializeComponent();
            addCinema = this;
            if(Cinema != null)
            {
                this.Cinema = Cinema;
                tb_name.Text = this.Cinema.NameCinema;
                tb_count_hall.Text = this.Cinema.CountHall.ToString();
                tb_count_place.Text = this.Cinema.CountPlace.ToString();
                btnAdd.Content = "Изменить";
            }
        }

        private void AddNewCinema_db(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = Classes.Connection.DBConnection.OpenConnection();
            if (btnAdd.Content.ToString() == "Добавить")
                Classes.Connection.DBConnection.Query($"INSERT INTO Cinemas.cinema (name_cinema, count_hall, count_place) VALUES ('{tb_name.Text}', '{Convert.ToInt32(tb_count_hall.Text)}', '{Convert.ToInt32(tb_count_place.Text)}')", connection);
            else if (btnAdd.Content.ToString() == "Изменить")
                Classes.Connection.DBConnection.Query($"UPDATE Cinemas.cinema SET name_cinema = '{tb_name.Text}', count_hall = '{tb_count_hall.Text}', count_place = '{tb_count_place.Text}' WHERE id = '{Cinema.Id}';", connection);
            else return;
            Classes.Connection.DBConnection.CloseConnection(connection);
            MainWindow.init.OpenPages(MainWindow.pages.cinema);
        }

        private void BackPage(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(MainWindow.pages.cinema);
        }
    }
}
