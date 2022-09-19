using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Edition
    {
        public int Id { get; set; }
        public string EditionName { get; set; }
        public string CountryOrigin { get; set; }
        public int Years { get; set; }
    }
}
