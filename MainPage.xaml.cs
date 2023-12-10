using Microsoft.Maui.Controls;
using System.Diagnostics;

namespace Pr2
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel myMainPageViewModel;
        public MainPage()
        {
            InitializeComponent();
            myMainPageViewModel = new MainPageViewModel();
            BindingContext = myMainPageViewModel;
            Console.WriteLine("MainPage constructor called");

            // Subscribe to ItemSelected event for the ListView
            staffListView.ItemSelected += OnItemSelected;

            // Subscribe to Clicked event for the Button
            addButton.Clicked += OnAddClicked;
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
