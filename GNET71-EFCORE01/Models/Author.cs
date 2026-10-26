using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GNET71_EFCORE01.Models
{
    internal class Author
    {
        public int Id { get; set; }
        public string? FristName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
