namespace Bluesport_MWG.Models
{
    public class SizeModel
    {
        public string name { get; set; }
        public int quantity { get; set; }
    }
    
    public static class SizeModelExt
    {
        public static bool IsDisable(this SizeModel sizeDto)
        {
            return sizeDto.quantity == 0;
        }
    }
}