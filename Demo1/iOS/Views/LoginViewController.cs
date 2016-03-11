using System;
using MvvmCross.Binding.BindingContext;
using UIKit;
using MvvmCross.iOS.Views;
using XamarinMALDemo1.ViewModels;

namespace XamarinMALDemo1.iOS.Views
{
    public partial class LoginViewController : MvxViewController<LoginViewModel>
    {
        //public LoginViewController() : base() { }

        public LoginViewController(IntPtr handle)
            : base(handle)
        {
            this.InitializeBindings();
        }

        private void InitializeBindings()
        {
            this.DelayBind(() =>
            {
                this.CreateBinding(txtUserId).For(c => c.Text).To<LoginViewModel>(vm => vm.UserId).Apply();
                this.CreateBinding(txtPassword).For(c => c.Text).To<LoginViewModel>(vm => vm.Password).Apply();
                this.CreateBinding(btnLogin).To<LoginViewModel>(vm => vm.LoginCommand).Apply();
            });
        }
    }
}
