namespace Bluesport_MWG.Models
{
    public class PromotionDetailModel
    {
        public string promotionInfo { get; set; }
        public bool isOnlinePromotion { get; set; }
        public bool isMore { get; set; }
    }

    public static class PromotionDetailModelExt
    {
        public static bool IsOnlinePromotion(this PromotionDetailModel promotionDetailModel)
        {
            return promotionDetailModel.isOnlinePromotion;
        }
        public static bool IsMore(this PromotionDetailModel promotionDetailModel)
        {
            return promotionDetailModel.isMore;
        }
    }

}