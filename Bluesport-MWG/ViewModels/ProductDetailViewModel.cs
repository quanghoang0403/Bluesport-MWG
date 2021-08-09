using Bluesport_MWG.Models;
using System.Collections.Generic;

namespace BlueSport_MWG.Models
{
    public class ProductDetailViewModel
    {
        public ProductModel _productModel { get; set; }
        public List<ProductModel> _relatedProducts { get; set; }
    }
}