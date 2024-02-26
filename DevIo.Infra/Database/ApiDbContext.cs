using DevIo.Business.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DevIo.Infra.Database
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Supplier> Suppliers { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
