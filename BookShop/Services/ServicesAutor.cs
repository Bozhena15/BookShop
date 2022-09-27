using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Services
{
    public class ServicesAutor
    {
           private readonly BookShopContext _bookShopContext;

            public ServicesAutor(BookShopContext bookShopContext)
            {
                _bookShopContext = bookShopContext;
            }

            public IEnumerable<Autor> GetAutor()
            {
                var autors = _bookShopContext.Autors.ToList();
                return autors;
            }

            public void AddNewAutor(Autor autor)
            {
                if (autor == null)
                {
                    throw new NullReferenceException(nameof(autor));
                }
                _bookShopContext.Autors.Add(autor);
                _bookShopContext.SaveChanges();
            }

            public void DeleteAutor(int id)
            {
                var autor = _bookShopContext.Autors.FirstOrDefault(x => x.Id == id);
                if (autor == null)
                {
                    throw new NullReferenceException(nameof(autor));
                }
                _bookShopContext.Autors.Remove(autor);
                _bookShopContext.SaveChanges();
            }
        }
    
}
