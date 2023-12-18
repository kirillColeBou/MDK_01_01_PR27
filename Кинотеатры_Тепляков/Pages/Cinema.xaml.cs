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

namespace Кинотеатры_Тепляков.Pages
{
    /// <summary>
    /// Логика взаимодействия для Cinema.xaml
    /// </summary>
    public partial class Cinema : Page
    {
        public List<CinemaContext> cinemaContexts = CinemaContext.AllCinemas();
        public Cinema()
        {
            InitializeComponent();
            CreateUI();
        }

        public void CreateUI()
        {
            parrent.Children.Clear();
            foreach(CinemaContext item in cinemaContexts)
            {
                parrent.Children.Add(new Elements.Item_cinema(item));
            }
        }

        private void AddNewCinema(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(MainWindow.pages.addCinema);
        }

        private void PosterWin(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(MainWindow.pages.main);
        }
    }
}
