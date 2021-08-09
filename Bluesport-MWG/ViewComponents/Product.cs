using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Bluesport_MWG.Models;
using System.Threading.Tasks;

namespace MWG_BlueSport.ViewComponents
{
    public class Product : ViewComponent
    {
        public IViewComponentResult Invoke(List<ProductModel> products, bool isPromo = false)
        {
            if (isPromo)
                return View("PromoProduct", products);

            return View("BlockProduct", products);
        }
    }
}