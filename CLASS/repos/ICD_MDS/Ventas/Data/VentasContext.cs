using Microsoft.EntityFrameworkCore;
using Ventas.Models;

namespace Ventas.Data
{
    public class VentasContext : DbContext
    {
        public VentasContext (DbContextOptions<VentasContext> options)
            : base(options)
        {
        }

        public DbSet<Bill> Bill { get; set; }
    }
}