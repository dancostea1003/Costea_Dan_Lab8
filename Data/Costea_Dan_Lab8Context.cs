using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Costea_Dan_Lab8.Models;

namespace Costea_Dan_Lab8.Data
{
    public class Costea_Dan_Lab8Context : DbContext
    {
        public Costea_Dan_Lab8Context (DbContextOptions<Costea_Dan_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Costea_Dan_Lab8.Models.Book> Book { get; set; }

        public DbSet<Costea_Dan_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Costea_Dan_Lab8.Models.Category> Category { get; set; }
    }
}
