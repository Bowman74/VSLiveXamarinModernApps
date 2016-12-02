using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Xamarin.Forms;
using XamarinMALDemo2.PresentaitonHints;

namespace XamarinMALDemo2
{
    public partial class ViewPresenter
    {
        public override void ChangePresentation(MvxPresentationHint hint)
        {
            if (hint is ClearBackstackHint)
            {
                var mainPage = Application.Current.MainPage as NavigationPage;
                if (mainPage != null && mainPage.CurrentPage != null)
                {
                    var navigation = mainPage.CurrentPage.Navigation;
                    for (var i = navigation.NavigationStack.Count - 1; i >= 0; i--)
                    {
                        var page = navigation.NavigationStack[i];
                        if (page != mainPage.CurrentPage)
                        {
                            navigation.RemovePage(page);
                        }
                    }
                }
            }
            base.ChangePresentation(hint);
        }
    }
}