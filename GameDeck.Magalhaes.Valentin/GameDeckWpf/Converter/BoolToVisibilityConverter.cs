using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace GameDeckWpf.Converter
{
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool bValue = true;
            try
            {
                bValue = (bool)value;
            }
            catch { }
            return bValue ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility vValue = Visibility.Collapsed;
            try
            {
                vValue = (Visibility)value;
            }
            catch { }
            return vValue == Visibility.Visible;
        }
    }
}
