using RestSharp;
using System.Collections.Generic;

namespace Bluesport_MWG.Services.Interface
{
    public interface IClientService
    {
        public IRestResponse Get(string path);
    }
}
