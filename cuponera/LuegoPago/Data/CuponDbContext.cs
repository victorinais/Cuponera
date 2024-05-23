

using LuegoPago.Models;
using Microsoft.EntityFrameworkCore;

namespace LuegoPago.Data
{
    public class CuponDbContext : DbContext
    {
        public CuponDbContext(DbContextOptions<DbContext> options): base(options)
        {
        }
        public DbSet<Cupon> Cupones { get; set; }
        
    }
}
