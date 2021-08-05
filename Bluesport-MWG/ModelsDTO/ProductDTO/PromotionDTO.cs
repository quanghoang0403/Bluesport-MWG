using System.Collections.Generic;
using Bluesport_MWG.Models;

namespace Bluesport_MWG.ModelDTO
{
    public class PromotionDTO
    {
        public string promotionName { get; set; }
        public List<PromotionDetailDTO> promotionList { get; set; }
    }
    
    public static class PromotionDTOExt
    {
        public static PromotionModel ToPromotionModel(this PromotionDTO promotionDto)
        {
            PromotionModel result = new PromotionModel();
            if (promotionDto != null)
            {

                result.promotionName = promotionDto.promotionName;
            
                result.promotionList = new List<PromotionDetailModel>();
            
                foreach (var item in promotionDto.promotionList)
                {
                    result.promotionList.Add(item.ToPromotionDetailModel());
                }
            }
            
            
            return result;
        }
    }
}