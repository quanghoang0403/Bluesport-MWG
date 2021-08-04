using Bluesport_MWG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bluesport_MWG.ModelsDTO
{
    public class StoreDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string address { get; set; }
        public string webAddress { get; set; }
        public string operatingTime { get; set; }
        public long phoneNumber { get; set; }
        public List<string> promotion { get; set; }
        public List<string> images { get; set; }
    }

    public static class StoreDTOExt
    {
        public static StoreModel ToStoreModel(this StoreDTO storeDTO)
        {
            Console.WriteLine(storeDTO.GetAddress());
            return new StoreModel()
            {
                name = storeDTO.name,
                slug = storeDTO.slug,
                address = storeDTO.GetAddress(),
                operatingTime = storeDTO.operatingTime,
                phoneNumber = storeDTO.phoneNumber,
                promotion = storeDTO.promotion,
                images = storeDTO.images
            };
        }

        public static string GetAddress(this StoreDTO storeDTO)
        {
            return string.IsNullOrEmpty(storeDTO.webAddress) ? storeDTO.address : storeDTO.webAddress;
        }
    }
    
}
