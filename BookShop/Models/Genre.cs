using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string BookGenre { get; set; }

        public List<Book> Books { get; set; }
    }
}
