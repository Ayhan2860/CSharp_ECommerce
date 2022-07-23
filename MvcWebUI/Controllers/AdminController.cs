using System;
using System.Linq;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
   
   [Authorize(Roles ="User")]
    public class AdminController:Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public AdminController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            
            var products = _productService.GetAll(); 
            var model = new ProductListViewModel
            {
                Products = products
            };

            return View(model);
        }

        public ActionResult AddProduct()
        {
            var productAddViewModel = new ProductAddViewModel
            {
                Product = new Product(),
                Categories =  _categoryService.GetAll()
            };

            return View(productAddViewModel);
        }

        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            if(!ModelState.IsValid)
            {
                  return View();
            }
            _productService.Add(product);
            TempData.Add("message", 
            String.Format($"Product was successfuly added"));
            
            return RedirectToAction("AddProduct");
        }

        public ActionResult UpdateProduct(int productId)
        {
            var model =  new ProductUpdateViewModel
            {
                 Product = _productService.GetById(productId),
                 Categories = _categoryService.GetAll()
            };

             return View(model);
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            if(!ModelState.IsValid)
            {
                  return View();
            }
            _productService.Update(product);
            TempData.Add("message", 
            String.Format($"Product was successfuly updated"));
            
            return RedirectToAction("Index");
        }



    
        public ActionResult DeleteProduct(int productId)
        {
             var product = _productService.GetById(productId);
            if(!ModelState.IsValid)
            {
                  return View();
            }
            _productService.Delete(product);
            TempData.Add("message", 
            String.Format($"Product '{product.ProductName}' was successfuly deleted"));
            
            return RedirectToAction("Index");
        }
    }
}