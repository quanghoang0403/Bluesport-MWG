using Bluesport_MWG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bluesport_MWG.Services.Interface
{
    public interface IBannerService
    {
        public Task<List<BannerModel>> GetAll();
    }
}
