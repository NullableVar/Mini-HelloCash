using Microsoft.EntityFrameworkCore;
using Mini_HelloCash.DataAccess.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_HelloCash.DataAccess;

public class Mini_HelloCashDb : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=TwiddleDb;Trusted_Connection=True;TrustServerCertificate=true");
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Role> Roles { get; set; }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Products> Products { get; set; }

    public DbSet<Bill> Bills { get; set; }
}
