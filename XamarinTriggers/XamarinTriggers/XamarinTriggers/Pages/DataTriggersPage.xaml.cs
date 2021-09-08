using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTriggers.ViewModels;

namespace XamarinTriggers.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataTriggersPage : ContentPage
    {
        private readonly DataTriggerViewModel _dataTriggerViewModel;

        public DataTriggersPage(DataTriggerViewModel dataTriggerViewModel)
        {
            InitializeComponent();
            this.BindingContext = _dataTriggerViewModel = dataTriggerViewModel;
        }
    }
}