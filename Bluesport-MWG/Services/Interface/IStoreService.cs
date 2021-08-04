using Bluesport_MWG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bluesport_MWG.Services.Interface
{
    public interface IStoreService
    {
        public List<StoreModel> GetAll();
        public StoreModel GetBySlug(string slug);
    }
}
