using System.Collections.Generic;
using Bluesport_MWG.ModelDTO;

namespace Bluesport_MWG.Models
{
    public class PromotionModel
    {
        public string promotionName { get; set; }
        public List<PromotionDetailModel> promotionList { get; set; }
    }
}