using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Boca_Danut_Lab8.Models;

namespace Boca_Danut_Lab8.Data
{
    public class Boca_Danut_Lab8Context : DbContext
    {
        public Boca_Danut_Lab8Context (DbContextOptions<Boca_Danut_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Boca_Danut_Lab8.Models.Book> Book { get; set; }

        public DbSet<Boca_Danut_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Boca_Danut_Lab8.Models.Category> Category { get; set; }
    }
}
