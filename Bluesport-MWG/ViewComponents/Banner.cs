using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Bluesport_MWG.Models;
using System.Threading.Tasks;

namespace MWG_BlueSport.ViewComponents
{
    public class Banner : ViewComponent
    {
        public IViewComponentResult Invoke(List<BannerModel> banners)
        {
            return View(banners);
        }
    }
}