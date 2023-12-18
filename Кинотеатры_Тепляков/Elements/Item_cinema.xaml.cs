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
    /// Логика взаимодействия для Item_cinema.xaml
    /// </summary>
    public partial class Item_cinema : UserControl
    {
        public Item_cinema(CinemaContext item)
        {
            InitializeComponent();
            nameCinema.Content = item.NameCinema;
            countHall.Content = "Количество залов: " + item.CountHall;
            countPlace.Content = "Количество мест: " + item.CountPlace;
        }

        private void Change(object sender, RoutedEventArgs e)
        {

        }

        private void Delete(object sender, RoutedEventArgs e)
        {

        }
    }
}
