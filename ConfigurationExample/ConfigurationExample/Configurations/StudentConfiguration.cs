using ConfigurationExample.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;


namespace ConfigurationExample.Configurations
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder
              .Property(s => s.Name)
              .HasMaxLength(50)
              .IsRequired();

           builder
               .Property(s => s.Surname)
               .HasMaxLength(50)
               .HasDefaultValue("XXX");

            builder
              .Property(s => s.Age)
              .IsRequired();

            builder
               .ToTable("Students");

            //modelBuilder
            //    .Entity<Student>()
            //    .HasKey(s => s.FinCode);

            //modelBuilder
            //   .Entity<Student>()
            //   .Property(s => s.FinCode)
            //   .HasColumnType("CHAR(7)");

            //modelBuilder
            //    .Entity<Student>()
            //    .HasMany(s => s.Subjects)
            //    .WithMany(sub => sub.Students)
            //    .UsingEntity(ss => ss.ToTable("student_subjects"));

        }
    }
}
