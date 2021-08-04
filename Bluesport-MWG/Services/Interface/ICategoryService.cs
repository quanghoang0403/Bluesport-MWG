using System.Collections.Generic;
using Bluesport_MWG.ModelDTO;
using Bluesport_MWG.Models;

namespace Bluesport_MWG.Service.Category
{
    public interface ICategoryService
    {
        public List<CategoryModel> GetAll();
    }
}