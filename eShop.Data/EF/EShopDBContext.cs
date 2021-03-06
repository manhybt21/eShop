using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.EF
{
    public class EShopDBContext : DbContext
    {
        public EShopDBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts {get;set;}

        public DbSet<CategoryTranslation> CategoryTranslations {get;set;}
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Language> Languages{ get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<OrderDetail> OrderDetails{ get; set; }
        public DbSet<ProductTranslation> ProductTranslations{ get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<AppConfig> AppConfigs { get; set; }
    }
}
