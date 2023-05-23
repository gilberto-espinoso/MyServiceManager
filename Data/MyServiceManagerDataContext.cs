using MyServiceManager.Data.Mappings;
using MyServiceManager.Models;
using Microsoft.EntityFrameworkCore;

namespace MyServiceManager.Data
{
    public class MyServiceManagerDataContext : DbContext
    {
        public MyServiceManagerDataContext(DbContextOptions<MyServiceManagerDataContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new PostMap());
        }
    }
}