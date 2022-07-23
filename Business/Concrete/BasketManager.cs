using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BasketManager : IBasketService
    {
        public void AddToBasket(Basket basket, Product product)
        {
             BasketLine line = basket.BasketLines.FirstOrDefault(b => b.Product.ProductId == product.ProductId);
             if(line != null)
             {
                  line.Quantity++;
                  return;
             }
             basket.BasketLines.Add(new BasketLine{Product = product, Quantity = 1});
        }

        public List<BasketLine> List(Basket basket)
        {
            return basket.BasketLines;
        }

      

        public void RemoveFromBasket(Basket basket, int productId)
        {
            basket.BasketLines.Remove(basket.BasketLines.FirstOrDefault(b => b.Product.ProductId == productId));
        }
    }
}