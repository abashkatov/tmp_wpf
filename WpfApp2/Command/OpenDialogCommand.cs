using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp2.Entity;
using WpfApp2.Service;

namespace WpfApp2.Command
{
    public class OpenDialogCommand : ICommand
    {
        private readonly Counter counter;
        private readonly ObservableCollection<User> users;
        private readonly UserUpdateService userUpdateService;

        public OpenDialogCommand(
            Counter counter, 
            ObservableCollection<User> users,
            UserUpdateService userUpdateService
            )
        {
            this.counter = counter;
            this.users = users;
            this.userUpdateService = userUpdateService;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            counter.Value++;
            uint num = (uint)users.Count;
            users.Add(userUpdateService.CreateUser(num));
            userUpdateService.UpdateUser(users[0], num);
        }
    }
}
