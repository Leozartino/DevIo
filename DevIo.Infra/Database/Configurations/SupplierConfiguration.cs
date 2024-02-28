using DevIo.Business.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIo.Infra.Database.Configurations
{
    internal class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    { 
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(property => property.Id);

            builder.Property(property => property.Name)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(property => property.Document)
                .IsRequired()
                .HasColumnType("varchar(14)");

            // 1 : 1 => Supplier : Address
            builder.HasOne(supplier => supplier.Address)
                .WithOne(adress => adress.Supplier);

            // 1 : N => Supplier : Products
            builder.HasMany(supplier => supplier.Products)
                .WithOne(p => p.Supplier)
                .HasForeignKey(p => p.SupplierId);

            builder.ToTable("Suppliers");
        }
    }
}
