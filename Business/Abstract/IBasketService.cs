using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface IBasketService
   {
       void AddToBasket(Basket basket, Product product);
       void RemoveFromBasket(Basket basket, int productId);
       List<BasketLine> List(Basket basket);
   } 
}