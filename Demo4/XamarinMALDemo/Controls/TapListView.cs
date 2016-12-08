using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinMALDemo.Controls
{
    public class TapListView : ListView
    {
        public static BindableProperty ItemTappedCommandProperty = BindableProperty.Create(nameof(ItemTappedCommand), typeof(ICommand), typeof(TapListView), null);

        public TapListView()
        {
            this.ItemTapped += this.OnItemTapped;
        }


        public ICommand ItemTappedCommand
        {
            get { return (ICommand)this.GetValue(ItemTappedCommandProperty); }
            set { this.SetValue(ItemTappedCommandProperty, value); }
        }


        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null && this.ItemTappedCommand != null && this.ItemTappedCommand.CanExecute(e))
            {
                this.ItemTappedCommand.Execute(e.Item);
                this.SelectedItem = null;
            }
        }
    }
}