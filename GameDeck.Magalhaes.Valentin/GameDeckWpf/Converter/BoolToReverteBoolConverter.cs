using System;
using System.Globalization;
using System.Windows.Data;

namespace GameDeckWpf.Converter
{
    [ValueConversion(typeof(bool), typeof(bool))]
    public class BoolToReverteBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DoWork(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DoWork(value);
        }

        private bool DoWork(object value)
        {
            bool bValue = true;
            try
            {
                bValue = (bool)value;
            }
            catch { }
            return !bValue;
        }
    }
}
