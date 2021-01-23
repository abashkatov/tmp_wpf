using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp2.Entity;
using WpfApp2.ViewModel;

namespace WpfApp2.Command
{
    public class GetItemCommand : ICommand
    {
        private readonly UserWindowViewModel windowViewModel;
        private readonly UserWindow window;

        public GetItemCommand(UserWindowViewModel windowViewModel, UserWindow window)
        {
            this.windowViewModel = windowViewModel;
            this.window = window;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            windowViewModel.User = parameter as User;
            window.Show();
        }
    }
}
