﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int BookCount { get; set; }

        public User User { get; set; }
        public Book Book { get; set; }
    }
}
