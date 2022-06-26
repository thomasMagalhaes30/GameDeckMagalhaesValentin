using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace GameDeckWpf.Converter
{
    [ValueConversion(typeof(string), typeof(DateTime))]
    public class StringToDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string sValue = "";
            try
            {
                sValue = System.Convert.ToString(value);
                List<int> d = sValue.Split('/').Select(v => int.Parse(v)).ToList();
                return new DateTime(d[2], d[1], d[0]);
            }
            catch { }

            //return DateTime.TryParse(sValue, out DateTime resultDateTime) ? resultDateTime : value;
            return DateTime.Today;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime? dValue = null;
            try
            {
                dValue = System.Convert.ToDateTime(value);
            }
            catch { }
            return dValue?.ToString();
        }
    }
}
