using EntityExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityExample.Data
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("server=MSI;database=EntityPA302;trusted_connection=true;integrated security=true;trustservercertificate=true;");

        }
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }



    }
}
