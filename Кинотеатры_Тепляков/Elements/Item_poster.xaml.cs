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

namespace Кинотеатры_Тепляков.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item_poster.xaml
    /// </summary>
    public partial class Item_poster : UserControl
    {
        public Item_poster(PosterContext item)
        {
            InitializeComponent();
            nameFilm.Content = item.NameFilm;
            nameCinema.Content = "Название кинотеатра: " + item.NameCinema;
            time.Content = "Время сеанса: " + item.Time;
            price.Content = "Цена билета: " + item.Price;
        }

        private void Change(object sender, RoutedEventArgs e)
        {

        }

        private void Delete(object sender, RoutedEventArgs e)
        {

        }
    }
}
