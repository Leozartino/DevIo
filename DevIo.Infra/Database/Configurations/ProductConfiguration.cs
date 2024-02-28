using DevIo.Business.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIo.Infra.Database.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(product => product.Id);

            builder.Property(product => product.Name)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(product => product.Description)
                .IsRequired()
                .HasColumnType("varchar(1000)");

            builder.Property(product => product.Image)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(product => product.Value)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.ToTable("Products");
                
        }
    }
}
