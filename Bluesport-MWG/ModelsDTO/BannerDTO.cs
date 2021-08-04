using Bluesport_MWG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bluesport_MWG.ModelsDTO
{
    public class BannerDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string pathImg { get; set; }
        public string altImg { get; set; }
        public string description { get; set; }
    }

    public static class BannerDTOExt
    {
        public static BannerModel ToBannerModel(this BannerDTO bannerDTO)
        {
            return new BannerModel()
            {
                pathImg = bannerDTO.pathImg,
                altImg = bannerDTO.altImg,
                description = bannerDTO.description
            };
        }
    }
}
