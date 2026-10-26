using System;
using System.Collections.Generic;
using System.Text;

namespace GNET71_EFCORE01.Models
{
    internal class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int PublictionYaer { get; set; }
        public bool instock { get; set; }


    }
}
