using Microsoft.EntityFrameworkCore;
using OnionPA302.Domain.Entities;
using System.Reflection;

namespace OnionPA302.Persistence.DAL
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("server=msi;database=onionpa302;trusted_connection=true;integrated security=true;trustservercertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Student> Students { get; set; }
    }
}
