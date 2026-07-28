using ConfigurationExample.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConfigurationExample.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .Property(p => p.Name)
                .HasColumnName("name")
                .HasColumnType("VARCHAR(150)")
                .HasMaxLength(150)
                .IsRequired();

            builder
               .Property(p => p.Price)
               .HasColumnType("DECIMAL(6,2)")
               .IsRequired();

            builder
                .HasIndex(p => p.Name)
                .IsUnique();

            //builder
            //    .HasKey(p => p.Product_Id);

            //builder
            //    .Property(p => p.Product_Id)
            //    .ValueGeneratedOnAdd();

            builder
              .HasOne(p => p.Category)
              .WithMany(c => c.Products)
              .HasForeignKey(p => p.Category_Id);

        }
    }
}
