using System.Collections.Generic;
using TradinPlatform.Basic.Models;

namespace WebApplication1.Models
{
    public class SearchIndexModel
    {
        public string SearchQuery { get; set; }
        public IEnumerable<Product> ProductsList { get; set; }
    }
}
