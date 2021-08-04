using System.Collections.Generic;
using System.Linq;
using Bluesport_MWG.ModelDTO;
using Bluesport_MWG.Models;
using Bluesport_MWG.Services.Interface;

namespace Bluesport_MWG.Service.Category
{
    public class CategoryService : ICategoryService
    {
        private string _apiName;
        private readonly IClientService _clientService;

        public CategoryService(IClientService clientService)
        {
            _apiName = "category";
            _clientService = clientService;
        }
        public List<CategoryModel> GetAll()
        {
            var response = _clientService.Get(_apiName);
            var dataDTO = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CategoryDTO>>(response.Content);
            var categoryModels = new List<CategoryModel>();
            if (dataDTO != null)
            {
                var rootCate = dataDTO.Where(x => x.level == 0).ToList();
                var subCate = dataDTO.Where(x => x.level == 1).ToList();
                var lastCate = dataDTO.Where(x => x.level == 2).ToList();
                foreach (var root in rootCate)
                {
                    var tempRoot = root.ToCategoryModel();
                    tempRoot.subCate = new List<CategoryModel>();
                    var subList = subCate.Where(x => x.parentId == tempRoot.id).ToList();
                    foreach (var sub in subList)
                    {
                        var tempSub = sub.ToCategoryModel();
                        var tempLast = lastCate.Where(x => x.parentId == sub.id).ToList();
                        tempSub.subCate = new List<CategoryModel>();
                        foreach (var item in tempLast)
                        {
                            tempSub.subCate.Add(item.ToCategoryModel());
                        }
                        tempRoot.subCate.Add(tempSub);
                    }
                    categoryModels.Add(tempRoot);
                }
            }
            return categoryModels;
        }
    }
}