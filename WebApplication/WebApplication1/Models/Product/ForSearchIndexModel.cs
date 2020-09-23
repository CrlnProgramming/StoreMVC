
//This class writing for the Search and Bussines pages.
namespace WebApplication1.Models.Product
{
    public class ForSearchIndexModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string IamgeUrl { get; set; }
        public int Category { get; set; }
        public string CategoryName { get; set; }
    }
}
