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
<<<<<<< HEAD
            _bookShopContext=bookShopContext;
=======
            _bookShopContext = bookShopContext;
>>>>>>> f9dfb05ded525fba54ee64ad27f256e23fe504a9
        }

        public IEnumerable<Order> GetOrders()
        {
            var orders = _bookShopContext.Orders.ToList();
            return orders;
        }

        public void AddNewOrders(Order order)
        {
<<<<<<< HEAD
            if (order == null)
=======
            if(order == null)
>>>>>>> f9dfb05ded525fba54ee64ad27f256e23fe504a9
            {
                throw new NullReferenceException(nameof(order));
            }
            _bookShopContext.Orders.Add(order);
            _bookShopContext.SaveChanges();
        }

<<<<<<< HEAD
        public void RemoveOrders(int id)
        {
            var order = _bookShopContext.Orders.FirstOrDefault(x => x.Id == id);

            if (order == null)
=======
        public void DeleteOrder(int id)
        {
            var order = _bookShopContext.Orders.FirstOrDefault(x => x.Id == id);
            if(order == null)
>>>>>>> f9dfb05ded525fba54ee64ad27f256e23fe504a9
            {
                throw new NullReferenceException(nameof(order));
            }
            _bookShopContext.Orders.Remove(order);
            _bookShopContext.SaveChanges();
        }
    }
}
