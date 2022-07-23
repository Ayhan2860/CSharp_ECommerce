
using System.Collections.Generic;
using System.Linq;

namespace Entities.Concrete
{
    public class Basket
    {
         public Basket()
         {
            BasketLines = new List<BasketLine>();
         }
        public List<BasketLine> BasketLines { get; set; }
        public decimal Total { get {return BasketLines.Sum(b=>b.Product.UnitPrice * b.Quantity); } }
    }
}