using System;
using System.Globalization;
using System.Windows.Data;

namespace GameDeckWpf.Converter
{
    [ValueConversion(typeof(DateTime), typeof(string))]
    public class DateToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime? dValue = null;
            try
            {
                dValue = System.Convert.ToDateTime(value);
            }
            catch { }
            return dValue?.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string sValue = "";
            try
            {
                sValue = System.Convert.ToString(value);
            }
            catch { }
            return DateTime.TryParse(sValue, out DateTime resultDateTime) ? resultDateTime : value;
        }
    }
}
