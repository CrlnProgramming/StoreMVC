using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Web.Data;
using Web.Data.Models;
using System.Text.RegularExpressions;
using System.Linq;

namespace Web.Service
{
    public class ProductService : IProduct
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void DeleteProduct(int id)
        {
            var product = GetById(id);
            if(product == null)
            {
                throw new ArgumentException();
            }
            _context.Remove(product);
            _context.SaveChanges();
        }

        public void EditProduct(Product product)
        {
            var model = _context.Products.First(p => p.Id == product.Id);
            _context.Entry<Product>(model).State = EntityState.Detached;
            _context.Update(product);
            _context.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.Include(product => product.Category);
        }

        public IEnumerable<Product> GetFilteredProduct(int id, string searchQuery)
        {
            if(string.IsNullOrEmpty(searchQuery) || string.IsNullOrWhiteSpace(searchQuery))
            {
                return GetProductByCategoryId(id);
            }
            return GetFilteredProduct(searchQuery).Where(product => product.Category.Id == id);
        }

        public IEnumerable<Product> GetFilteredProduct(string searchQuery)
        {
            var queries = string.IsNullOrEmpty(searchQuery) ? null : Regex.Replace(searchQuery,
                @"\s+", " ").Trim().ToLower().Split(" ");
            if(queries == null)
            {
                return GetPreferred(10);
            }

            return GetAll().Where(item => queries.Any(query => (item.Name.ToLower().Contains(query))));
        }

        public IEnumerable<Product> GetPreferred(int count)
        {
            return GetAll().OrderByDescending(product => product.Id)
                .Where(product => product.IsPreferedProduct && product.InStock != 0).Take(count);
        }

        public Product GetById(int id)
        {
            return GetAll().FirstOrDefault(product => product.Id == id);
        }

        public IEnumerable<Product> GetProductByCategoryId(int categoryId)
        {
            return GetAll().Where(product => product.Category.Id == categoryId);
        }

        public void NewProduct(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
        }

    }
}
