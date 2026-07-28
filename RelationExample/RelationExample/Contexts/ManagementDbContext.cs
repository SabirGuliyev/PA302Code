using Microsoft.EntityFrameworkCore;
using RelationExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationExample.Contexts
{
    internal class ManagementDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseSqlServer("server=msi;database=relationEntityDB;trusted_connection=true;integrated security=true;trustservercertificate=true;");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
    }
}
