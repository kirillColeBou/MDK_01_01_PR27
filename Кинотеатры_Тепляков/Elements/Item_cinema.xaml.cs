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
using Кинотеатры_Тепляков.Classes;
using Кинотеатры_Тепляков.Models;
using Кинотеатры_Тепляков.Pages;

namespace Кинотеатры_Тепляков.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item_cinema.xaml
    /// </summary>
    public partial class Item_cinema : UserControl
    {
        public CinemaContext cinema;
        public Item_cinema(CinemaContext item)
        {
            InitializeComponent();
            cinema = item;
            nameCinema.Content = item.NameCinema;
            countHall.Content = "Количество залов: " + item.CountHall;
            countPlace.Content = "Количество мест: " + item.CountPlace;
        }

        private void Change(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(MainWindow.pages.addCinema);
            AddCinema.addCinema.btnAdd.Content = "Изменить";
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = Classes.Connection.DBConnection.OpenConnection();
            Classes.Connection.DBConnection.Query($"DELETE FROM Cinemas.poster WHERE id_cinema = '{cinema.Id}'", connection);
            Classes.Connection.DBConnection.CloseConnection(connection);
            connection = Classes.Connection.DBConnection.OpenConnection();
            Classes.Connection.DBConnection.Query($"DELETE FROM Cinemas.cinema WHERE id = '{cinema.Id}'", connection);
            Classes.Connection.DBConnection.CloseConnection(connection);
            MainWindow.init.OpenPages(MainWindow.pages.cinema);
        }
    }
}
