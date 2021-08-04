using Microsoft.Extensions.Configuration;
using Bluesport_MWG.Services.Interface;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Bluesport_MWG.Services
{
    public class ClientService : IClientService
    {
        private string _url;
        private string _basePath;

        public ClientService()
        {
            //var url = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build()["Urls"];
            //var client = new RestClient(url + "banner");
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var url = configuration.GetSection("BaseUrl").Value;
            var basePath = configuration.GetSection("BasePath").Value;

            _url = url;
            _basePath = basePath;
        }
        public IRestResponse Get(string path)
        {
            var client = new RestClient(_url + _basePath + path);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            return response;
        }
    }
}
