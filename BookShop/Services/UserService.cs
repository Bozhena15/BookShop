using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookShop.Models;

namespace BookShop.Services
{
    public class UserService
    {
        private readonly BookShopContext _bookShopContext;

        public UserService(BookShopContext bookShopContext)
        {
            _bookShopContext = bookShopContext;
        }
        
        public IEnumerable<User> GetUsers()
        {
            var users = _bookShopContext.Users.ToList();
            return users;
        }

        public void AddNewUsers(User user)
        {
            if (user==null)
            {
                throw new NullReferenceException(nameof(user));
            }
            _bookShopContext.Users.Add(user);
            _bookShopContext.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = _bookShopContext.Users.FirstOrDefault(x=>x.Id==id);
            if (user==null)
            {
                throw new NullReferenceException(nameof(user));
            }
            _bookShopContext.Users.Remove(user);
            _bookShopContext.SaveChanges();
        }
    }
}
