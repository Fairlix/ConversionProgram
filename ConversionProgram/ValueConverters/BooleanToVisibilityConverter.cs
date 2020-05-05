using System;
using System.Globalization;
using System.Windows;

namespace ConversionProgram

{
    public class BooleanToVisibilityConverter : BaseValueConverter<BooleanToVisibilityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)

        {
            return (bool)value ? Visibility.Hidden : Visibility.Visible;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culute)
        {
            throw new NotImplementedException();
        }
    }
}