using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int GraduationYears { get; set; }
        public int BookPrice { get; set; }
        public int BookCost { get; set; }
        public int BookCount { get; set; }
        public int AutorId { get; set; }
        public int GenreId { get; set; }
        public int EditionId { get; set; }
       public virtual Autor Autor { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Edition Edition { get; set; }

        public List<Order> Orders { get; set; }
    }
}
