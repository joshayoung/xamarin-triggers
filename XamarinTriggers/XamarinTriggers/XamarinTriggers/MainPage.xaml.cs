using System;
using Xamarin.Forms;
using XamarinTriggers.Pages;

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
            Navigation.PushAsync(new PropertyTriggerPage());
        }

        private void DataTriggers(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DataTriggersPage());
        }
    }
}