using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bluesport_MWG.Services.Interface
{
    public interface IClientService
    {
        public Task<IRestResponse> Get(string path);
    }
}
