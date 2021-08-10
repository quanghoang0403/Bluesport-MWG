using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Bluesport_MWG.Models;
using Bluesport_MWG.ModelsDTO;
using Bluesport_MWG.Services.Interface;
using RestSharp;

namespace Bluesport_MWG.Services
{
    public class ProductService : IProductService
    {
        private string _apiName;
        private readonly IClientService _clientService;
        private readonly ILoggerManager _logger;
        public ProductService(IClientService clientService, ILoggerManager logger)
        {
            _clientService = clientService;
            _apiName = "product";
            _logger = logger;
        }
        public async Task<ProductModel> Get(string id)
        {
            var response = await _clientService.Get(_apiName + "/" + id);
            var productDTO = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductDTO>(response.Content);
            return productDTO.ToProductModel();
        }
        public async Task<List<ProductModel>> GetAll()
        {
            _logger.LogInfo("Fetching all the Students from the storage");
            var response = await _clientService.Get(_apiName);
            var productDTO = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ProductDTO>>(response.Content);
            List<ProductModel> productModels = new List<ProductModel>();
            #region Mapping
            foreach (var item in productDTO)
            {
                productModels.Add(item.ToProductModel());
            }
            #endregion
            _logger.LogInfo($"Returning {productModels.Count} product.");
            return productModels;
        }

        public async Task<ProductModel> GetBySlug(string slug)
        {
            var response = await _clientService.Get(_apiName + "/" + slug);

            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductDTO>(response.Content);


            return dataDto.ToProductModel();
        }
    }
}
