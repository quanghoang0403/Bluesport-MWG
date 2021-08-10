using Bluesport_MWG.Extensions;
using Bluesport_MWG.ModelDTO;
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
        public string slug { get; set; }
        public string image { get; set; }
        public float priceCurrent { get; set; }
        public float priceOld { get; set; }
        public float saleOff { get; set; }
        public string brandName { get; set; }
        public string brandInfo { get; set; }
        public string description { get; set; }
        public string imageBrand { get; set; }
        public Dictionary<string, string>[] productDetail { get; set; }
        public List<SizeDTO> sizes { get; set; }
        public PromotionDTO promotion { get; set; }
    }

    public static class ProductDTOExt
    {
        public static ProductModel ToProductModel(this ProductDTO productDTO)
        {
            var result = new ProductModel()
            {
                name = productDTO.name,
                image = productDTO.image,
                priceCurrent = productDTO.priceCurrent.ToCurrency(),
                priceOld = productDTO.priceOld.ToCurrency(),
                percentSaleOff = productDTO.saleOff.ToPercent(),
                brandName = productDTO.brandName,
                brandInfo = productDTO.brandInfo,
                description = productDTO.description,
                imageBrand = productDTO.imageBrand,
                productDetail = productDTO.productDetail,

                slug = productDTO.slug,
                promotion = productDTO.promotion.ToPromotionModel()
            };

            result.sizes = new List<SizeModel>();
            if (productDTO.sizes != null)
            {
                foreach (var item in productDTO.sizes)
                {
                    result.sizes.Add(item.ToSizeModel());
                }
            }

            return result;
        }
    }
}
