using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Bluesport_MWG.Extensions
{
    public static class ConvertStringExtensions
    {
        public static string ToCurrency(this float price)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            return price.ToString("#,###", cul.NumberFormat) + "₫";
        }

        public static string ToPercent(this float saleOff)
        {
            return '-' + (saleOff * 100).ToString() + '%';
        }
    }
}
