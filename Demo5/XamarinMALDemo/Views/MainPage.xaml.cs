
using Xamarin.Forms;
using System;

#if __ANDROID__
using Xamarin.Forms.Platform.Android;
using Android.Support.Design.Widget;
#endif

namespace XamarinMALDemo.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            Title = "Polls";

            NavigationPage.SetHasNavigationBar(this, true);

#if __ANDROID__
            NativeViewWrapper actionButtonView = null;
            foreach (var control in mainLayout.Children)
            {
                if (control is NativeViewWrapper && ((NativeViewWrapper)control).NativeView is FloatingActionButton)
                {
                    actionButtonView = (NativeViewWrapper)control;
                }
            }
            if (actionButtonView != null)
            {
                var actionButton = (FloatingActionButton)actionButtonView.NativeView;
                actionButton.SetImageResource(XamarinMALDemo.Droid.Resource.Drawable.ic_add_white_24dp);
            }



            //var actionButton = new FloatingActionButton(Forms.Context);

            //actionButton.SetImageResource(XamarinMALDemo.Droid.Resource.Drawable.ic_add_white_24dp);
            //actionButton.Click += fab_click;

            //var actionButtonView = (NativeViewWrapper)actionButton.ToView();
            //actionButtonView.HorizontalOptions = LayoutOptions.End;
            //actionButtonView.VerticalOptions = LayoutOptions.End;
            //actionButtonView.Margin = 16;
            //mainLayout.Children.Add(actionButtonView);
#else
            ToolbarItems.Add(new ToolbarItem("Add", "Add", Toolbar_Click));
#endif
		}

        void Toolbar_Click()
        {
            DisplayAlert("Click", "Been clicked", "OK");
        }

        private void fab_click(object sender, EventArgs e)
        {
            Toolbar_Click();
        }
	}
}