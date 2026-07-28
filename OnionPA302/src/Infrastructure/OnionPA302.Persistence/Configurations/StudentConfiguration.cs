using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionPA302.Domain.Entities;

namespace OnionPA302.Persistence.Configurations
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(s => s.Name)
                .IsRequired()
                .HasColumnType("VARCHAR(50)");

            builder.Property(s => s.Age)
                .HasAnnotation("Range", new[] { 0, 65 });

            builder.ToTable(t => t.HasCheckConstraint("CK_Students_Age", "Age >= 0 AND Age <= 65"));

            builder.Property(s => s.Email)
                .IsRequired(false)
                .HasColumnType("VARCHAR(256)");

            builder.HasIndex(s => s.Email)
                .IsUnique();
        }
    }
}
