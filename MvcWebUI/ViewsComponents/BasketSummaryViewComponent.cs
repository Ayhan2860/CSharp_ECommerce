using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvcWebUI.Models;
using MvcWebUI.Services;

namespace MvcWebUI.ViewsComponents
{
     public class BasketSummaryViewComponent:ViewComponent
     {
        private readonly IBasketSessionService _basketSessionService;

        public BasketSummaryViewComponent(IBasketSessionService basketSessionService)
        {
            _basketSessionService = basketSessionService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model =  new BasketSummaryViewModel
            {
                 Basket = _basketSessionService.GetBasket()
            };
            return View(model);
            
        }

       
    }
}