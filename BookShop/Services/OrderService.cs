using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookShop.Models;

namespace BookShop.Services
{
    public class OrderService
    {
        private readonly BookShopContext _bookShopContext;

        public OrderService(BookShopContext bookShopContext)
        {
            _bookShopContext = bookShopContext;
        }

        public IEnumerable<Order> GetOrders()
        {
            var orders = _bookShopContext.Orders.ToList();
            return orders;
        }

        public void AddNewOrders(Order order)
        {
            if(order == null)
            {
                throw new NullReferenceException(nameof(order));
            }
            _bookShopContext.Orders.Add(order);
            _bookShopContext.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            var order = _bookShopContext.Orders.FirstOrDefault(x => x.Id == id);
            if(order == null)
            {
                throw new NullReferenceException(nameof(order));

            }
            _bookShopContext.Orders.Remove(order);
            _bookShopContext.SaveChanges();
        }
    }
}
