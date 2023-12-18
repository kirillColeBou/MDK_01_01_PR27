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
using MySql.Data.MySqlClient;

namespace Кинотеатры_Тепляков.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddPoster.xaml
    /// </summary>
    public partial class AddPoster : Page
    {
        public static AddPoster addPoster;
        public List<CinemaContext> cinemaContexts = CinemaContext.AllCinemas();
        public Models.Poster Poster;
        public AddPoster(Models.Poster Poster = null)
        {
            InitializeComponent();
            addPoster = this;
            CreateCinema();
            if (Poster != null)
            {
                this.Poster = Poster;
                string name_cinema = Poster.NameCinema;
                cb_name_cinema.Text = name_cinema;
                tb_name_film.Text = this.Poster.NameFilm;
                tb_time.Text = this.Poster.Time;
                tb_price.Text = this.Poster.Price;
                btnAdd.Content = "Изменить";
            }
        }

        public void CreateCinema()
        {
            cb_name_cinema.Items.Clear();
            foreach (CinemaContext item in cinemaContexts)
            {
                ComboBoxItem items = new ComboBoxItem();
                items.Tag = item.Id;
                items.Content = item.NameCinema;
                cb_name_cinema.Items.Add(items);
            }
        }

        private void AddNewPoster_db(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = Classes.Connection.DBConnection.OpenConnection();
            ComboBoxItem selectedItem = cb_name_cinema.SelectedItem as ComboBoxItem;
            if (btnAdd.Content.ToString() == "Добавить")
                Classes.Connection.DBConnection.Query($"INSERT INTO Cinemas.poster (id_cinema, name_film, time, price) VALUES ('{selectedItem.Tag}', '{tb_name_film.Text}', '{tb_time.Text}', '{tb_price.Text}')", connection);
            else if (btnAdd.Content.ToString() == "Изменить")
                Classes.Connection.DBConnection.Query($"UPDATE Cinemas.poster SET id_cinema = '{selectedItem.Tag}', name_film = '{tb_name_film.Text}', time = '{tb_time.Text}', price = '{tb_price.Text}' WHERE id = '{Poster.Id}';", connection);
            else return;
            Classes.Connection.DBConnection.CloseConnection(connection);
            MainWindow.init.OpenPages(MainWindow.pages.main);
        }

        private void BackPage(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(MainWindow.pages.main);
        }
    }
}
