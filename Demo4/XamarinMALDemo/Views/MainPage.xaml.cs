
using Xamarin.Forms;

namespace XamarinMALDemo.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            Title = "Polls";

            NavigationPage.SetHasNavigationBar(this, true);

		}
	}
}