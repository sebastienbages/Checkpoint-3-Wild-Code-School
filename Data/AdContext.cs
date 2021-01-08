using checkpoint3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace checkpoint3
{
    public class AdContext : DbContext
    {
        public AdContext(DbContextOptions<AdContext> options)
            : base(options)
        {

        }
        public DbSet<Ad> Ad { get; set; }
    }
}
