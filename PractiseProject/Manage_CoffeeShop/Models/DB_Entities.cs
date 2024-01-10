
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace Manage_CoffeeShop.Models
{
    public class DB_Entities : DbContext
    {
        public DB_Entities(DbContextOptions<DB_Entities> options) : base(options)
        {
        }
       

        public DbSet<Product> Products { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
       
      
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .Property(u => u.Id)
                .IsRequired();

            modelBuilder.Entity<Product>()
               .Property(u => u.Id)
               .IsRequired();


            //relationship
            modelBuilder.Entity<Users>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);



        }

     



    }

}


