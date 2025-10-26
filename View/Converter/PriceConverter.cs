using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.UI.Xaml.Data;

namespace App1.View.Converter
{
    public class PriceConverter : IValueConverter
    {
        public string CurrencySymbol { get; set; } = "₫";
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null) return "";

            try
            {
                // Chuyển giá trị sang dạng số
                if (decimal.TryParse(value.ToString(), out decimal price))
                {
                    // Định dạng tiền tệ Việt Nam (1.000.000 ₫)
                    string formatted = string.Format(new CultureInfo("vi-VN"), "{0:N0}", price);

                    // Thêm ký hiệu tiền tệ (có thể đặt phía sau hoặc phía trước)
                    return string.Format("{0:N0} {1}", price, CurrencySymbol);
                }
                else
                {
                    return value?.ToString() ?? string.Empty;
                }
            }
            catch
            {
                return value?.ToString() ?? string.Empty;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
