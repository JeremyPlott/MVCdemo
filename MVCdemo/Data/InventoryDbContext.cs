using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCdemo.Models;

namespace MVCdemo.Models
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext (DbContextOptions<InventoryDbContext> options)
            : base(options)
        {
        }

        public DbSet<MVCdemo.Models.Vendor> Vendor { get; set; } // can change white vendor name here, then hover and use change name to fix other occurrences

        public DbSet<MVCdemo.Models.Product> Product { get; set; }
    }
}
