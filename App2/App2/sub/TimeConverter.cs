using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2.sub
{
    class TimeConverter : IValueConverter
    {
        const string DEFAULT = "--:--";
        const string PARTERN = "HH:mm";
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return DEFAULT;
            }
            DateTime time = (DateTime)value;
            return time.ToString(PARTERN);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
