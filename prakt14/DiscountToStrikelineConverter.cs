using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;
using System.Globalization;
namespace prakt14
{

    public class DiscountToStrikelineConverter : IValueConverter
    {
        public object Convert(object value, Type target, object parametr, CultureInfo culture)
        {
            bool HasDiscount = (bool)value;
            if (HasDiscount)
            {
                return TextDecorations.Strikethrough;
            }
            else
            {
                return new TextDecoration();
            }
        }

        public object ConvertBack(object value, Type target, object parametr, CultureInfo culture)
        {
            var decoration = value as TextDecoration;
            if (decoration != null)
            {
                return decoration.Location == TextDecorationLocation.Strikethrough;

            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
