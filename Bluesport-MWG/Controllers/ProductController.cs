using Bluesport_MWG.Service.Category;
using Bluesport_MWG.Services.Interface;
using BlueSport_MWG.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bluesport_MWG.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET
        [Route("san-pham/{slug}")]
        public async Task<IActionResult> Detail(string slug)
        {
            ProductDetailViewModel viewModel = new ProductDetailViewModel();
            viewModel._productModel = await _productService.GetBySlug(slug);
            viewModel._relatedProducts = await _productService.GetAll();
            return View(viewModel);
        }
    }
}
