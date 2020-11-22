using System;
using System.Collections.Generic;
using System.Text;
using Web.Data.Enum;
using Web.Data.Models;

namespace Web.Data
{
    public interface IOrder
    {
        void CreateOrder(Order order);
        Order GetById(int orderId);
        IEnumerable<Order> GetByUserId(string userId);
        IEnumerable<Order> GetAll();
        IEnumerable<Order> GetUserLatersOrder(int count, string userId);
        IEnumerable<Product> GetUserMostPopularProduct(string id);
        IEnumerable<Order> GetFilteredOreds(
            string userId = null,
            OrderBy orderBy = OrderBy.None,
            int offset = 0,
            int limit = 10,
            decimal? minimalPrice = null,
            decimal? maximalPrice = null,
            DateTime? minDate = null,
            DateTime? maxDate = null,
            string zipCode = null
            );
    }
}
