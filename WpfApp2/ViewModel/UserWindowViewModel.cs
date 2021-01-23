using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Entity;

namespace WpfApp2.ViewModel
{
    public class UserWindowViewModel: INotifyPropertyChanged
    {
        private User user;
        public void Subscribe(INotifyPropertyChanged mainWindowViewModel)
        {
            mainWindowViewModel.PropertyChanged += (sender, e) => {
                if (e.PropertyName == "SelectedUser") {
                    User = (sender as MainWindowViewModel).SelectedUser;
                }
            };
        }
        public User User { 
            get => user;
            set 
            {
                user = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("User"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
