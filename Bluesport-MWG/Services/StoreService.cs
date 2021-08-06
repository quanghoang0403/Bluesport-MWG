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
    public class StoreService : IStoreService
    {
        private string _apiName;
        private readonly IClientService _clientService;
        public StoreService(IClientService clientService)
        {
            _clientService = clientService;
            _apiName = "store";
        }
        public async Task<List<StoreModel>> GetAll()
        {
            var response = await _clientService.Get(_apiName);
            var storeDTO = Newtonsoft.Json.JsonConvert.DeserializeObject<List<StoreDTO>>(response.Content);
            List<StoreModel> storeModels = new List<StoreModel>();

            #region Mapping
            foreach (var item in storeDTO)
            {
                storeModels.Add(item.ToStoreModel());
            }
            #endregion

            return storeModels;
        }

        public async Task<StoreModel> GetBySlug(string slug)
        {
            var response = await _clientService.Get(_apiName + "/" + slug);
            var dataDTO = Newtonsoft.Json.JsonConvert.DeserializeObject<StoreDTO>(response.Content);

            return dataDTO.ToStoreModel();
        }
    }
}
