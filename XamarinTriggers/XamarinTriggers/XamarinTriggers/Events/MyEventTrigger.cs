using Xamarin.Forms;

namespace XamarinTriggers.Events
{
    public class MyEventTrigger : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            sender.BackgroundColor = Color.Tomato;
        }
    }
}