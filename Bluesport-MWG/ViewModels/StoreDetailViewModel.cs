using System.Collections.Generic;

namespace Bluesport_MWG.Models
{
    public class StoreDetailViewModel : BaseViewModel
    {
        public StoreModel _store { get; set; }
        public List<StoreModel> _grandOpeningStore { get; set; }
    }
}