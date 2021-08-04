using Bluesport_MWG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bluesport_MWG.Models
{
    public class HomeViewModel : BaseViewModel
    {
        public List<BannerModel> bannerModels { get; set; }
        public List<StoreModel> storeModels { get; set; }
        public List<ProductModel> productModels { get; set; }
    }
}
