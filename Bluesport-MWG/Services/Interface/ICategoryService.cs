using System.Collections.Generic;
using System.Threading.Tasks;
using Bluesport_MWG.ModelDTO;
using Bluesport_MWG.Models;

namespace Bluesport_MWG.Service.Category
{
    public interface ICategoryService
    {
        public Task<List<CategoryModel>> GetAll();
    }
}