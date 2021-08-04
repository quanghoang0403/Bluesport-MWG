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
        public ProductService(IClientService clientService)
        {
            _clientService = clientService;
            _apiName = "product";
        }
        public List<ProductModel> GetAll()
        {
            var response = _clientService.Get(_apiName);
            var productDTO = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ProductDTO>>(response.Content);
            List<ProductModel> productModels = new List<ProductModel>();

            #region Mapping
            foreach (var item in productDTO)
            {
                productModels.Add(item.ToProductDTO());
            }
            #endregion

            return productModels;
        }
    }
}
