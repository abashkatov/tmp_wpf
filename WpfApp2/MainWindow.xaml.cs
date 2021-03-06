﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp2.Entity;
using WpfApp2.ViewModel;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<User> Users { get; }

        public MainWindow(MainWindowViewModel context,ObservableCollection<User> users)
        {
            InitializeComponent();

            DataContext = context;
            Users = users;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
        }
    }
}
