using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstApproachNew.Models
{
    class SalesDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               optionsBuilder.UseSqlServer("Data Source=DESKTOP-PP0TB7N;Initial Catalog=SalesDB;Integrated Security=True");
            }
        }

        public DbSet<Sales> Sales { get; set; }
    }
}
