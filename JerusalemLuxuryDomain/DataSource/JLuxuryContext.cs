using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JerusalemLuxuryDomain.Models;
using System.Data.Entity;


namespace JerusalemLuxuryDomain.DataSource
{
    class JLuxuryContext : DbContext
    {
        public DbSet<Accounting> Accounting { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<CardInfo> CardInfo { get; set; }
        public DbSet<Description> Description { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Poster> Posters { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyCategory> PropertyCategories { get; set; }
        public DbSet<ShortTermCategory> ShortTermCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
