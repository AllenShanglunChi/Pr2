
using Microsoft.Maui.Controls;
using System.Diagnostics;

namespace Pr2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
            Console.WriteLine("MainPage constructor called");
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Debug.WriteLine("OnItemSelected executed");

            if (e.SelectedItem == null)
                return;

            var selectedStaff = e.SelectedItem as Staff;
            Navigation.PushAsync(new StaffProfileDetailsPage(selectedStaff, (MainPageViewModel)BindingContext));

            // Deselect item
            ((ListView)sender).SelectedItem = null;
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            Debug.WriteLine("OnAddClicked executed");
            // Handle the Add button click event
            Navigation.PushAsync(new AddStaffProfilePage((MainPageViewModel)BindingContext));
        }
    }
}
