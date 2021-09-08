using System;
using Xamarin.Forms;
using XamarinTriggers.Pages;
using XamarinTriggers.ViewModels;

namespace XamarinTriggers
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PropertyTriggers(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PropertyTriggersPage());
        }

        private void DataTriggers(object sender, EventArgs e)
        {
            var dataTriggerViewModel = new DataTriggerViewModel();
            // If this has a value, it will display on the page:
            dataTriggerViewModel.FullName = "Set this to an empty string to hide the label";
            Navigation.PushAsync(new DataTriggersPage(dataTriggerViewModel));
        }

        private void EventTriggers(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EventTriggersPage());
        }
    }
}