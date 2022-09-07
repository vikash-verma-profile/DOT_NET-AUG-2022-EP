using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstApproach
{
    public class CustomerEFContext : DbContext
    {
        //constructor to inject the options
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-PP0TB7N;Initial Catalog=CustomerEF;Integrated Security=True");
            }
        }
        DbSet<Employee> Employees { get; set; }
    }
}
