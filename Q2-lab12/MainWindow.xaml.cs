using System.Windows;
using WpfApp.DataContext;
using WpfApp.ViewModels;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public OrderViewModel ViewModel { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new OrderViewModel();
            DataContext = new
            {
                ViewModel,
                Appointments = DataStore.GetAppointmentDetails()
            };
        }

        private void OnAddOrUpdateAddress(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Update existing address?", "Address Management",
                                         MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Yes)
            {
                ViewModel.AddOrUpdateAddress("New Address", true);
            }
            else if (result == MessageBoxResult.No)
            {
                ViewModel.AddOrUpdateAddress("New Address", false);
            }
        }
    }
}
