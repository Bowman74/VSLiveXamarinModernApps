using MvvmCross.Forms.Presenter.iOS;
using UIKit;
using Xamarin.Forms;

namespace XamarinMALDemo
{
    public partial class ViewPresenter : MvxFormsIosPagePresenter
    {
        public ViewPresenter(UIWindow window, Application application) : base(window, application) { }
    }
}