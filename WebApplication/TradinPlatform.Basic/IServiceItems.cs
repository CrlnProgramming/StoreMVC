using System;
using TradinPlatform.Basic.Models;

namespace TradinPlatform.Basic
{
    public interface IServiceItems
    {
        IEquatable<Product> GetAll();
        IEquatable<Product> GetFilterProduct(string searchQuery);
        Product GetByIdProduct(int id);
        void NewFood(Product product);
        void EditProduct(Product product);
        void DeleteFood(int id);
    }
}
