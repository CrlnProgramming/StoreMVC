using System.Collections.Generic;
using TradinPlatform.Basic.Models;
using WebApplication1.Models.Product;

namespace WebApplication1.Models
{
    public class SearchIndexModel
    {
        public string SearchQuery { get; set; }
        public IEnumerable<ForSearchIndexModel> ProductsList { get; set; }
    }
}
