using System;
using System.Data.Entity;
using System.Linq;

namespace TeknoTrendWebApp.Models
{
    public class TeknoTrendDBModel : DbContext
    {

        public TeknoTrendDBModel()
            : base("name=TeknoTrendDBModel")
        {
        }

        public DbSet<ManagerType> ManagerTypes { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Campaigns> Campaigns { get; set; }
        public DbSet<Satislar> Satislar { get; set; }
        public DbSet<SatisDetaylar> SatisDetaylar { get; set; }


    }


}