using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookShop.Models;


namespace BookShop.Services
{
    public class EditionService
    {
        private readonly BookShopContext _bookShopContext;

        public EditionService(BookShopContext bookShopContext)
        {
            _bookShopContext = bookShopContext;
        }

        public IEnumerable<Edition> GetEdition()
        {
            var editions = _bookShopContext.Editions.ToList();
            return editions;
        }

        public void AddNewEdition(Edition edition)
        {
            if (edition == null)
            {
                throw new NullReferenceException(nameof(edition));
            }
            _bookShopContext.Editions.Add(edition);
            _bookShopContext.SaveChanges();
        }

        public void DeleteEdition(int id)
        {
            var edition = _bookShopContext.Editions.FirstOrDefault(x => x.Id == id);
            if (edition == null)
            {
                throw new NullReferenceException(nameof(edition));
            }
            _bookShopContext.Editions.Remove(edition);
            _bookShopContext.SaveChanges();
        }
    }
}
