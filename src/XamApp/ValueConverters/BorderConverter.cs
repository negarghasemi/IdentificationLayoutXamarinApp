using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace XamApp.ValueConverters
{

    public class BorderConverter : Bit.View.ValueConverter<string, Color>
    {
        protected override Color Convert(string text, Type targetType, object parameter, CultureInfo culture)
        {
          if(!string.IsNullOrEmpty(text))
                return Color.Black;
            return Color.SlateGray;
        }
    }
}
