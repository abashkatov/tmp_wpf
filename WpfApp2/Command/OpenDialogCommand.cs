using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp2.Entity;

namespace WpfApp2.Command
{
    public class OpenDialogCommand : ICommand
    {
        private readonly Counter counter;
        private readonly ObservableCollection<User> users;

        public OpenDialogCommand(Counter counter, ObservableCollection<User> users)
        {
            this.counter = counter;
            this.users = users;
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
            users.Add(new User("Ivan" + num, 20 + num));
            users[0].Name = users[0].Name + num;
            users[0].Age = users[0].Age + num;
        }
    }
}
