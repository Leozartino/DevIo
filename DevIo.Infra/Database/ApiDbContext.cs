using DevIo.Business.Model;
using Microsoft.EntityFrameworkCore;

namespace DevIo.Infra.Database
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Supplier> Suppliers { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

         
          
    }
}
