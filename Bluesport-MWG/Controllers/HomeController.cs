using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bluesport_MWG.Models;
using Bluesport_MWG.Service.Category;
using Bluesport_MWG.Services.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Bluesport_MWG.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBannerService _bannerService;
        private readonly IStoreService _storeService;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public HomeController(ILogger<HomeController> logger, IBannerService bannerService,
            IStoreService storeService, IProductService productService, ICategoryService categoryService)
        {
            _logger = logger;
            _bannerService = bannerService;
            _storeService = storeService;
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.bannerModels = _bannerService.GetAll();
            homeViewModel.storeModels = _storeService.GetAll();
            homeViewModel.productModels = _productService.GetAll();
            homeViewModel._categories = _categoryService.GetAll();
            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
