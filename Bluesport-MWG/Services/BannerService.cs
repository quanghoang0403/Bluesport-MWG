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
    public class BannerService : IBannerService
    {
        private string _apiName;
        private readonly IClientService _clientService;

        public BannerService(IClientService clientService)
        {
            _clientService = clientService;
            _apiName = "banner";
        }
        public async Task<List<BannerModel>> GetAll()
        {
            var response = await _clientService.Get(_apiName);
            var bannerDTO = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BannerDTO>>(response.Content);
            List<BannerModel> bannerModels = new List<BannerModel>();

            #region Mapping
            foreach (var item in bannerDTO)
            {
                bannerModels.Add(item.ToBannerModel());
            }
            #endregion

            return bannerModels;
        }
    }
 
}
