﻿using System;
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
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public List<PosterContext> posterContexts = PosterContext.AllPosters();
        public Main()
        {
            InitializeComponent();
            CreateUI();
        }

        public void CreateUI()
        {
            parrent.Children.Clear();
            foreach(PosterContext item in posterContexts)
            {
                parrent.Children.Add(new Elements.Item_poster(item));
            }
        }

        private void AddNewPoster(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(MainWindow.pages.addPoster);
        }

        private void CinemaWin(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(MainWindow.pages.cinema);
        }
    }
}
