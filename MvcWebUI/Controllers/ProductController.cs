using System;
using System.Linq;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class ProductController:Controller
    {
        private readonly  IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index(int page = 1, int category = 0)
        {
            int pageSize = 9;
            var products = _productService.GetByCategory(category); 
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.Skip((page -1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(products.Count/(double)pageSize),
                PageSize  = pageSize,
                CurrentCategory = category,
                CurrentPage = page
            };
            return View(model);
        }

       
       
       
        
    }
}