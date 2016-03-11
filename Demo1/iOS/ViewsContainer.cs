using MvvmCross.Platform.Platform;
using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using UIKit;

namespace XamarinMALDemo1.iOS
{
    public class ViewsContainer : MvxIosViewsContainer
    {
        protected override IMvxIosView CreateViewOfType(Type viewType, MvxViewModelRequest request)
        {
            MvxTrace.Trace(MvxTraceLevel.Diagnostic, "Create iOS View:" + viewType.Name);
            var storyboard = UIStoryboard.FromName("Main", null);
            var returnValue = storyboard.InstantiateViewController(viewType.Name);

            return (IMvxIosView)returnValue;
        }
    }
}