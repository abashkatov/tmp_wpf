using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfApp2.Command;
using WpfApp2.Entity;

namespace WpfApp2.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public OpenDialogCommand OpenDialogCommand { get; }
        public GetItemCommand GetItemCommand { get; }
        public AuthCommand AuthCommand { get; }

        private User selectedUser;
        public string Password { get; set; }
        public User SelectedUser
        {
            get => selectedUser;
            set
            {
                selectedUser = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedUser"));
            }
        }
        public Counter Counter { get; }
        public ObservableCollection<User> Users { get; }

        public MainWindowViewModel(
            Counter counter, 
            ObservableCollection<User> users, 
            OpenDialogCommand openDialogCommand,
            GetItemCommand getItemCommand,
            UserWindowViewModel userWindowViewModel,
            AuthCommand authCommand
            )
        {
            Counter = counter;
            Users = users;
            OpenDialogCommand = openDialogCommand;
            GetItemCommand = getItemCommand;
            AuthCommand = authCommand;
            userWindowViewModel.Subscribe(this);
        }
    }
}
