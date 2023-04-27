using System.Globalization;

namespace ListViewMaui
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var customerInfo = value as dynamic;
            if (customerInfo == null)
                return null;
            var employeeID = (int)customerInfo["EmployeeID"] % 9;
            return ImageSource.FromResource("ListViewMaui.Images.Ellipse63" + employeeID + ".png");
        }
         
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
