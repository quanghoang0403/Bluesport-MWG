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
        private readonly ICategoryService _categoryService;
        public StoreController(IStoreService storeService, ICategoryService categoryService)
        {
            _storeService = storeService;
            _categoryService = categoryService;
        }
        // GET
        [Route("cua-hang/{slug}")]
        public IActionResult Detail(string slug)
        {
            var viewModel = new StoreDetailViewModel();
            viewModel._categories = _categoryService.GetAll();
            viewModel._store = _storeService.GetBySlug(slug);
            viewModel._grandOpeningStore = _storeService.GetAll();
            return View(viewModel);
        }
    }
}
