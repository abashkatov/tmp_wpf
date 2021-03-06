﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp2.Command;
using WpfApp2.Entity;
using WpfApp2.Service;
using WpfApp2.ViewModel;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<MainWindowViewModel, MainWindowViewModel>();
            services.AddSingleton<Counter>();
            services.AddSingleton<OpenDialogCommand>();
            services.AddSingleton<GetItemCommand>();
            services.AddSingleton<UserWindow>();
            services.AddSingleton<UserWindowViewModel>();
            services.AddSingleton<UserUpdateService>();
            services.AddSingleton<AuthCommand>();
            
            ObservableCollection<User> users = new ObservableCollection<User>();
            users.Add(new User("Ivan", 20));
            services.AddSingleton(typeof(ObservableCollection<User>), users);

            services.AddSingleton<MainWindow>();

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            MainWindow window = serviceProvider.GetService<MainWindow>();

            window.Show();
        }
    }
}
