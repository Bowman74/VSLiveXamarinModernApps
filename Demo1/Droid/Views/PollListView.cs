using Android.Content;
using Android.Util;
using MvvmCross.Binding.Droid.Views;
using XamarinMALDemo1.Droid.Adapters;

namespace XamarinMALDemo1.Droid.Views
{
    public class PollListView : MvxListView
    {
        public PollListView(Context context, IAttributeSet attrs)
            : base(context, attrs, new PollListAdapter(context))
        {
        }
    }
}