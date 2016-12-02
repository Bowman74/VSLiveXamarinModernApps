
using Xamarin.Forms;

#if __ANDROID__
using Xamarin.Forms.Platform.Android;
using Android.Support.Design.Widget;
#endif

namespace XamarinMALDemo3.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            Title = "Polls";

            #if __ANDROID__
            var actionButton = new FloatingActionButton(Forms.Context);

            actionButton.SetImageResource(XamarinMALDemo3.Droid.Resource.Drawable.ic_add_white_24dp);

            var actionButtonView = actionButton.ToView();
            actionButtonView.HorizontalOptions = LayoutOptions.End;
            actionButtonView.VerticalOptions = LayoutOptions.End;
            actionButtonView.Margin = 10;

            mainLayout.Children.Add(actionButtonView);
            #else
            ToolbarItems.Add(new ToolbarItem("Add", "Add", () => {}));
            #endif
		}
	}
}