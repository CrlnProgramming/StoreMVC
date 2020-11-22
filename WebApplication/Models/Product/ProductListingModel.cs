using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models.Category;

namespace WebApplication.Models.Product
{
    public class ProductListingModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Total { get => (Price * Amount)
                .ToString("c", CultureInfo.CreateSpecificCulture("ru-RU")); }
        public int InStock { get; set; }
        public string ImageUrl { get; set; }
        public string ShortDescription { get; set; }
        public int Amount { get; set; }
        public CategoryListingModel Category { get; set; }
    }
}
