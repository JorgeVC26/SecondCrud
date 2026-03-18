using Microsoft.EntityFrameworkCore;
using SecondCrud.Models;
using System.Collections.Generic;

namespace SecondCrud.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
