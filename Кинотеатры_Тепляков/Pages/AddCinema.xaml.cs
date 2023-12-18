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
        public AddCinema()
        {
            InitializeComponent();
        }

        private void AddNewCinema_db(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(MainWindow.pages.cinema);
        }

        private void BackPage(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(MainWindow.pages.cinema);
        }
    }
}
