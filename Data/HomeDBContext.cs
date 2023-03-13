using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Demo3.Models;

namespace Demo3.Data
{
    public class HomeDBContext : DbContext
    {
        public HomeDBContext (DbContextOptions<HomeDBContext> options)
            : base(options)
        {
        }

        public DbSet<Demo3.Models.House> House { get; set; } = default!;
    }
}
