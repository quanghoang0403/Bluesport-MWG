using Bluesport_MWG.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Bluesport_MWG.ModelsDTO
{
    public class ProductDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public float priceCurrent { get; set; }
        public float priceOld { get; set; }
        public float saleOff { get; set; }
        public string brandName { get; set; }
        public string imageBrand { get; set; }
    }

    public static class ProductDTOExt
    {
        public static ProductModel ToProductDTO(this ProductDTO productDTO)
        {
            return new ProductModel()
            {
                name = productDTO.name,
                image = productDTO.image,
                priceCurrent = productDTO.priceCurrent.ToCurrency(),
                priceOld = productDTO.priceOld.ToCurrency(),
                percentSaleOff = productDTO.saleOff.ToPercent(),
                brandName = productDTO.brandName,
                imageBrand = productDTO.imageBrand
            };
        }

        public static string ToCurrency(this float price)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   
            return price.ToString("#,###", cul.NumberFormat)+"đ";
        }

        public static string ToPercent(this float saleOff)
        {
            return '-'+(saleOff*100).ToString()+'%';
        }
    }
}
