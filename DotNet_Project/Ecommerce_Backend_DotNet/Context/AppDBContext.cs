using EcommerceBackend_DotNet.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Backend_DotNet.Context
{
    public class AppDBContext : DbContext
    {

            public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
            { 

            }


            public DbSet<Users> Users { get; set; }
            public DbSet<Products> Products { get; set; }
            public DbSet<Orders> Orders { get; set; }
            public DbSet<OrderItems> OrderItems { get; set; }
            public DbSet<Cart> Cart { get; set; }
    
    }
}
