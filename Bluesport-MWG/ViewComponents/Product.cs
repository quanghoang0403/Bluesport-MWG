using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Bluesport_MWG.Models;
using System.Threading.Tasks;

namespace MWG_BlueSport.ViewComponents
{
    public class Product : ViewComponent
    {
        public IViewComponentResult Invoke(List<ProductModel> products, bool whitebg = true)
        {
            if (whitebg)
                return View("WhiteBackground", products);

            return View("BlueBackground", products);
        }
    }
}