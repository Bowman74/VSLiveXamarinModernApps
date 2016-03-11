using System;
using Android.App;
using Android.OS;
using Android.Widget;
using XamarinMALDemo1.Droid.Views;
using XamarinMALDemo1.ViewModels;

namespace XamarinMALDemo1.Droid
{
    [Activity(Label = "XamarinMALDemo1")]
    public class LoginActivity : ActivityBase<LoginViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Login);
        }
    }
}


