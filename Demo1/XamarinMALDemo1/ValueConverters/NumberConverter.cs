using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace XamarinMALDemo1.ValueConverters
{
    public class NumberConverter : MvxValueConverter<int, string>
    {
        protected override string Convert(int value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString("#,#");
        }
    }
}