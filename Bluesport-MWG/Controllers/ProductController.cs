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
        private readonly ICategoryService _categoryService;
        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        // GET
        [Route("san-pham/{slug}")]
        public IActionResult Detail(string slug)
        {
            ProductDetailViewModel viewModel = new ProductDetailViewModel();
            viewModel._productModel = _productService.GetBySlug(slug);
            viewModel._relatedProducts = _productService.GetAll();
            viewModel._categories = _categoryService.GetAll();
            return View(viewModel);
        }
    }
}
