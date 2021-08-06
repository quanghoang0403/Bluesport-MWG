using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Bluesport_MWG.Models;
using System.Threading.Tasks;

namespace MWG_BlueSport.ViewComponents
{
    public class Store : ViewComponent
    {
        public IViewComponentResult Invoke(List<StoreModel> stores)
        {
            return View(stores);
        }
    }
}