using Xamarin.Forms;

namespace XamarinTriggers.Events
{
    public class MyClickedEvent : TriggerAction<Button>
    {
        protected override async void Invoke(Button sender)
        {
            await sender.ScaleTo(0.75, 150, Easing.SinIn);
            await sender.ScaleTo(1, 150, Easing.SinOut);
            sender.BackgroundColor = Color.Tomato;
        }
    }
}