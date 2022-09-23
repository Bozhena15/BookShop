using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookShop.Models;

namespace BookShop.Services
{
   public class ServicesGenre
    {
        private readonly BookShopContext _bookShopContext;

        public ServicesGenre(BookShopContext bookShopContext) 
        {
            _bookShopContext = bookShopContext;
        }

        public IEnumerable<Genre> GetGenres()
        {
            var genres = _bookShopContext.Genre.ToList();
            return genres;
        }

        public void AddNewGenres(Genre genre) 
        {
            if (genre == null) 
            {
                throw new NullReferenceException(nameof(genre));
            }
            _bookShopContext.Genre.Add(genre);
            _bookShopContext.SaveChanges();
        }

        public void DeleteGenre(int id)
        {
            var genre = _bookShopContext.Genre.FirstOrDefault(x => x.Id == id);
            if (genre==null) 
            {
                throw new NullReferenceException(nameof(genre));
            }
            _bookShopContext.Genre.Remove(genre);
            _bookShopContext.SaveChanges();
        }
    }
}
