using NodaTime;
using NodaTime.Text;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace App1.Converters
{
    public class MinutesToStringConverter : IValueConverter
    {
        public object? Convert(object value, Type targetType, object parameter, CultureInfo culture) => value is int minutes
            ? Duration.FromMinutes(minutes).ToString("H:mm", CultureInfo.InvariantCulture)
            : null;

        public object? ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string timeString)
            {
                var result = DurationPattern.CreateWithInvariantCulture("H:mm").Parse(timeString);
                if (result.Success)
                {
                    return (int)result.Value.TotalMinutes;
                }
                else
                {
                    return null;
                }
            }
            else return null;
        }
    }
}
