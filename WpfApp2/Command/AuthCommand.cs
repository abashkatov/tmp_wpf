using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp2.Command
{
    public class AuthCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is PasswordBox)
            {
                MessageBox.Show((parameter as PasswordBox).Password);
            }
            else
            {
                //MessageBox.Show();
            }
        }
    }
}
