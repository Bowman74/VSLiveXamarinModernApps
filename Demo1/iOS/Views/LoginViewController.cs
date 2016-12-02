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

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            txtUserId.ShouldReturn += TxtUserId_ShouldReturn;
            txtPassword.ShouldReturn += TxtUserId_ShouldReturn;
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
            if (txtUserId != null && txtPassword != null)
            {
                txtUserId.ShouldReturn -= TxtUserId_ShouldReturn;
                txtPassword.ShouldReturn -= TxtUserId_ShouldReturn;
            }
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

        private bool TxtUserId_ShouldReturn(UITextField textField)
        {
            textField.ResignFirstResponder();
            return true;
        }
    }
}
