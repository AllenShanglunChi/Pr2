using Microsoft.Maui.Controls;

namespace Pr2
{
    public partial class StaffProfileDetailsPage : ContentPage
    {
        private Staff _selectedStaff;
        private MainPageViewModel _viewModel;

        public StaffProfileDetailsPage(Staff selectedStaff, MainPageViewModel viewModel)
        {
            InitializeComponent();
            _selectedStaff = selectedStaff;
            _viewModel = viewModel;
            BindingContext = _selectedStaff;
        }

        private void OnUpdateClicked(object sender, System.EventArgs e)
        {
            // Pass the selected staff and the view model instance to the UpdateStaffProfilePage
            Navigation.PushAsync(new UpdateStaffProfilePage(_selectedStaff, _viewModel));
        }

        private void OnBackClicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
