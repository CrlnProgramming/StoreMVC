using System;
using System.Collections.Generic;
using System.Text;

namespace TradinPlatform.Basic.Models
{
   public class Basket
   {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Sum { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
