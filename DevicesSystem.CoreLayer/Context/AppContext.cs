
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevicesSystem.CoreLayer
{
    public class AppDbContext : DbContext
    {
        // Dependency Injection Constructor
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DeviceProperties>()
               .HasKey(d => new { d.Category_Id, d.Device_Id,d.Property_Id,d.User_Id });
        }
    }
}
