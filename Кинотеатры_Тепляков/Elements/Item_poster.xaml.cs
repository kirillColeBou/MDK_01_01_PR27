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
using Кинотеатры_Тепляков.Pages;
using MySql.Data.MySqlClient;

namespace Кинотеатры_Тепляков.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item_poster.xaml
    /// </summary>
    public partial class Item_poster : UserControl
    {
        public PosterContext poster;
        public CinemaContext cinema;
        public Item_poster(PosterContext item)
        {
            InitializeComponent();
            poster = item;
            nameFilm.Content = item.NameFilm;
            nameCinema.Content = "Название кинотеатра: " + item.NameCinema;
            time.Content = "Время сеанса: " + item.Time;
            price.Content = "Цена билета: " + item.Price;
        }

        private void Change(object sender, RoutedEventArgs e)
        {
            MainWindow.init.frame.Navigate(new Pages.AddPoster(poster));
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = Classes.Connection.DBConnection.OpenConnection();
            MySqlDataReader command = Classes.Connection.DBConnection.Query($"DELETE FROM Cinemas.poster WHERE id = '{poster.Id}'", connection);
            Classes.Connection.DBConnection.CloseConnection(connection);
            MainWindow.init.OpenPages(MainWindow.pages.main);
        }
    }
}
