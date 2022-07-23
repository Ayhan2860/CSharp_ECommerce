using System.Collections.Generic;
using Entities.Concrete;

namespace MvcWebUI.Models
{
     public class ProductUpdateViewModel
     {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
     }
}