using Microsoft.AspNetCore.Mvc;
using Bluesport_MWG.Models;
using Bluesport_MWG.Service.Category;
using Bluesport_MWG.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bluesport_MWG.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStoreService _storeService;
        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }
        // GET
        [Route("cua-hang/{slug}")]
        public async Task<IActionResult> Detail(string slug)
        {
            var viewModel = new StoreDetailViewModel();
            viewModel._store = await _storeService.GetBySlug(slug);
            viewModel._grandOpeningStore = await _storeService.GetAll();
            return View(viewModel);
        }
    }
}
