using MvvmCross.Forms.Presenter.WindowsUWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.WindowsUWP.Views;
using Xamarin.Forms;

namespace XamarinMALDemo
{
    public partial class ViewPresenter : MvxFormsWindowsUWPPagePresenter
    {
        public ViewPresenter(IMvxWindowsFrame rootFrame, Application mvxFormsApp) : base(rootFrame, mvxFormsApp) {}

        protected override void CustomPlatformInitialization(NavigationPage mainPage)
        {
            base.CustomPlatformInitialization(mainPage);
        }
    }
}
