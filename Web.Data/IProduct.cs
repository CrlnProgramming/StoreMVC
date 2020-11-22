using System;
using System.Collections.Generic;
using System.Text;
using Web.Data.Models;

namespace Web.Data
{
    public interface IProduct
    {
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetPreferred(int count);
        IEnumerable<Product> GetProductByCategoryId(int categoryId);
        IEnumerable<Product> GetFilteredProduct(int id, string searchQuery);
        IEnumerable<Product> GetFilteredProduct(string searchQuery);
        Product GetById(int id);
        void NewProduct(Product product);
        void EditProduct(Product product);
        void DeleteProduct(int id);
    }
}
