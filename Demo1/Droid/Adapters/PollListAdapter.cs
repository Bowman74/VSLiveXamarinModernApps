using Android.Content;
using Android.Views;
using MvvmCross.Binding.Droid.Views;

namespace XamarinMALDemo1.Droid.Adapters
{
    class PollListAdapter : MvxAdapter
    {
        public PollListAdapter(Context context) : base(context) { }

        protected override View GetView(int position, View convertView, ViewGroup parent, int templateId)
        {
            var view = base.GetView(position, convertView, parent, templateId);
            return view;
        }
    }
}