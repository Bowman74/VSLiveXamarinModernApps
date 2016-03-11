using Xamarin.Forms;

namespace XamarinMALDemo3.Controls
{
    public class GradientButton : Button
    {
        public static BindableProperty StartGradientColorProperty = BindableProperty.Create<GradientButton, Color>(x => x.StartGradientColor, Color.Transparent);

        public Color StartGradientColor
        {
            get { return (Color)this.GetValue(StartGradientColorProperty); }
            set { this.SetValue(StartGradientColorProperty, value); }
        }

        public static BindableProperty EndGradientColorProperty = BindableProperty.Create<GradientButton, Color>(x => x.EndGradientColor, Color.Transparent);

        public Color EndGradientColor
        {
            get { return (Color)this.GetValue(EndGradientColorProperty); }
            set { this.SetValue(EndGradientColorProperty, value); }
        }
    }
}