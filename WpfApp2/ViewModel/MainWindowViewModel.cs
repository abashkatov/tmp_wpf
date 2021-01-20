using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfApp2.Entity;

namespace WpfApp2.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Counter Counter { get; }
        public ObservableCollection<User> Users { get; }

        public MainWindowViewModel(Counter counter, ObservableCollection<User> users)
        {
            Counter = counter;
            Users = users;
        }
    }
}
