using DevIo.Business.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIo.Infra.Database.Configurations
{
    internal class AdressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(adress => adress.Id);

            builder.Property(address => address.Street)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(address => address.Number)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(address => address.PostalCode)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(address => address.Complement)
                .HasColumnType("varchar(250)");

            builder.Property(address => address.Neighbourhood)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(address => address.Municipality)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(address => address.AdministrativeArea)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.ToTable("Addresses");
        }
    }
}
