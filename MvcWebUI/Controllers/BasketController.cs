using System;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;
using MvcWebUI.Services;

namespace MvcWebUI.Controllers
{
    public class BasketController:Controller
    {
        private readonly IBasketService _basketService;
        private readonly IProductService _productService;
        private readonly IBasketSessionService _basketSessionService;

        public BasketController(IBasketService basketService, IProductService productService, IBasketSessionService basketSessionService = null)
        {
            _basketService = basketService;
            _productService = productService;
            _basketSessionService = basketSessionService;
        }

        public ActionResult AddToBasket(int productId)
        {
                var product = _productService.GetById(productId);
                var basket = _basketSessionService.GetBasket();
                _basketService.AddToBasket(basket, product);
                _basketSessionService.SetBasket(basket);
                TempData.Add("message", $"Your product, {product.ProductName}, was successfuly added to the basket ");
                return  RedirectToAction("Index", "Product");
        }

        public ActionResult List()
        {
             var basket = _basketSessionService.GetBasket();
             BasketSummaryViewModel model = new BasketSummaryViewModel{
                Basket = basket
             };
             
            return View(model);
        }

        public ActionResult Remove(int productId)
        {
            var basket = _basketSessionService.GetBasket();
            _basketService.RemoveFromBasket(basket,  productId);
            _basketSessionService.SetBasket(basket);
             TempData.Add("message", $"Your product  was successfuly removed from the basket ");
            return RedirectToAction("List", "Basket");
        }

         public ActionResult Complete()
        {
            var shippingDetailsViewModel = new ShippingDetailsViewModel
            {
                 ShippingDetails = new ShippingDetails()
            };
            return View(shippingDetailsViewModel);
        }

        [HttpPost]
        public ActionResult Complete(ShippingDetails shippingDetails)
        {
            
            if(!ModelState.IsValid)
            {
                
                return View();
            }
            TempData.Add("message", 
            String.Format($"Thank you {shippingDetails.FirstName} {shippingDetails.LastName} you order is in process"));
            return RedirectToAction("Index", "Product");
        }
    }
}