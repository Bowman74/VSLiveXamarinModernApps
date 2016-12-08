using System.ComponentModel;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinMALDemo.Controls;
using XamarinMALDemo.Droid.Renderers;
using Button = Xamarin.Forms.Button;

[assembly: ExportRenderer(typeof(GradientButton), typeof(GradientButtonRenderer))]
namespace XamarinMALDemo.Droid.Renderers
{
    public class GradientButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            var model = Element as GradientButton;
            if (model != null)
            {
                var gradient = GetGradientDrawable(model.StartGradientColor.ToAndroid(), model.EndGradientColor.ToAndroid());
                Control.SetBackground(gradient);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == "StartGradientColor" || e.PropertyName == "EndGradientColor")
            {
                var model = Element as GradientButton;
                if (model != null)
                {
                    var gradient = GetGradientDrawable(model.StartGradientColor.ToAndroid(), model.EndGradientColor.ToAndroid());
                    Control.SetBackground(gradient);
                }
            }
        }

        private Drawable GetGradientDrawable(Android.Graphics.Color startColor, Android.Graphics.Color endColor)
        {
            var layers = new Drawable[1];

            var shader = new CustomShaderFactory(startColor, endColor);
            var drawable = new PaintDrawable();
            drawable.Shape = new RectShape();
            drawable.SetShaderFactory(shader);
            layers[0] = drawable;
            return new LayerDrawable(layers);
        }

        private class CustomShaderFactory : ShapeDrawable.ShaderFactory
        {
            private Android.Graphics.Color _startColor;
            private Android.Graphics.Color _endColor;

            public CustomShaderFactory(Android.Graphics.Color startColor, Android.Graphics.Color endColor)
            {
                _startColor = startColor;
                _endColor = endColor;
            }

            public override Shader Resize(int width, int height)
            {
                return new LinearGradient(0, 0, 0, 50, _startColor, _endColor, Shader.TileMode.Clamp);
            }
        }
    }
}