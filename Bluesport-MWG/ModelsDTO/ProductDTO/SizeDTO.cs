using Bluesport_MWG.Models;

namespace Bluesport_MWG.ModelDTO
{
    public class SizeDTO
    {
        public string name { get; set; }
        public int quantity { get; set; }
    }

    public static class SizeDTOExt
    {
        public static bool IsDisable(this SizeDTO sizeDto)
        {
            return sizeDto.quantity == 0;
        }

        public static SizeModel ToSizeModel(this SizeDTO sizeDto)
        {
            return new SizeModel()
            {
                name = sizeDto.name,
                quantity = sizeDto.quantity,
            };
        }
    }
}