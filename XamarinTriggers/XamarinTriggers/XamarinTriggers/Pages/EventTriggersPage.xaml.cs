using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTriggers.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventTriggersPage : ContentPage
    {
        private bool isClicked;
        
        public EventTriggersPage()
        {
            InitializeComponent();
        }

        private void ToggleButtonColor(object sender, EventArgs e)
        {
            var button = (Button)sender;
            isClicked = !isClicked;
            button.BackgroundColor = isClicked ? Color.Tomato : Color.Khaki;
        }
    }
}