
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
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<StudentCourse>()
            //   .HasKey(c => new { c.Student_Id, c.Course_Id });
        }
    }
}
