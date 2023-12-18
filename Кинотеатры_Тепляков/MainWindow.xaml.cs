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

namespace Кинотеатры_Тепляков
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow init;
        public MainWindow()
        {
            InitializeComponent();
            init = this;
            OpenPages(pages.main);
        }

        public enum pages
        {
            main, addPoster, cinema, addCinema
        }

        public void OpenPages(pages _pages)
        {
            if (_pages == pages.main)
                frame.Navigate(new Pages.Main());
            if (_pages == pages.addPoster)
                frame.Navigate(new Pages.AddPoster());
            if (_pages == pages.cinema)
                frame.Navigate(new Pages.Cinema());
            if (_pages == pages.addCinema)
                frame.Navigate(new Pages.AddCinema());
        }
    }
}
