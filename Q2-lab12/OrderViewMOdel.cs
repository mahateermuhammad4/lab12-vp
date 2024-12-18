using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp.ViewModels
{
    public class OrderViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> Addresses { get; set; } = new()
        {
            "123 Main Street",
            "456 Elm Street",
            "789 Oak Avenue"
        };

        private string _selectedAddress;
        public string SelectedAddress
        {
            get => _selectedAddress;
            set
            {
                _selectedAddress = value;
                OnPropertyChanged();
            }
        }

        public void AddOrUpdateAddress(string newAddress, bool updateExisting)
        {
            if (updateExisting && Addresses.Contains(SelectedAddress))
            {
                int index = Addresses.IndexOf(SelectedAddress);
                Addresses[index] = newAddress;
            }
            else if (!string.IsNullOrWhiteSpace(newAddress) && !Addresses.Contains(newAddress))
            {
                Addresses.Add(newAddress);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
