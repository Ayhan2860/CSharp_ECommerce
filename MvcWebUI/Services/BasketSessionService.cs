using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using MvcWebUI.ExtensionMethods;

namespace MvcWebUI.Services
{
    public class BasketSessionService : IBasketSessionService
    {
         private readonly IHttpContextAccessor _httpCotextAccessor;

        public BasketSessionService(IHttpContextAccessor httpCotextAccessor)
        {
            _httpCotextAccessor = httpCotextAccessor;
        }

        public Basket GetBasket()
        {
           Basket basketToCheck =  _httpCotextAccessor.HttpContext.Session.GetObject<Basket>("basket");
           if(basketToCheck == null)
           {
             _httpCotextAccessor.HttpContext.Session.SetObject("basket", new Basket());
             basketToCheck  = _httpCotextAccessor.HttpContext.Session.GetObject<Basket>("basket");

           }
            return basketToCheck;
        }

        public void SetBasket(Basket basket)
        {
           _httpCotextAccessor.HttpContext.Session.SetObject("basket", basket);
        }
    }
}