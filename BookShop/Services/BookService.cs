using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookShop.Models;

namespace BookShop.Services
{
    public class BookService
    {
        private readonly BookShopContext _bookShopContext;

        public BookService(BookShopContext bookShopContext)
        {
            _bookShopContext=bookShopContext;
        }

        public IEnumerable<Book> GetBooks()
        {
            var books = _bookShopContext.Books.ToList();
            return books;
        }

        public void AddNewBooks(Book book)
        {
            if(book ==null)
            {
                throw new NullReferenceException(nameof(book));
            }
            _bookShopContext.Books.Add(book);
            _bookShopContext.SaveChanges();
        }

        public void RemoveBooks(int id)
        {
            var book = _bookShopContext.Books.FirstOrDefault(x => x.Id == id);

            if(book == null)
            {
                throw new NullReferenceException(nameof(book));
            }
            _bookShopContext.Books.Remove(book);
            _bookShopContext.SaveChanges();
        }
    }
}
