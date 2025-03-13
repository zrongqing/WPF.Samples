using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace TreeListVIew.ValueConverter
{
    /// <summary>
    /// 减法转换器
    /// </summary>
    public class SubtractionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double val = System.Convert.ToDouble(value);
            var parame = System.Convert.ToDouble(parameter);
            return val - parame;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double val = System.Convert.ToDouble(value);
            var parame = System.Convert.ToDouble(parameter);
            return val + parame;
        }
    }
}
