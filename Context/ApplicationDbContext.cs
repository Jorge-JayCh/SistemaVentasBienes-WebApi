using Microsoft.EntityFrameworkCore;
using SistemaVentasBienes.Models;
using System.Reflection.Metadata;

namespace SistemaVentasBienes.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Condicion> Condicion { get; set; }
        public DbSet<Forma_Pago> Forma_Pago { get; set; }
        public DbSet<Tipo_Inmueble> Tipo_Inmueble { get; set; }
        public DbSet<Inmueble> Inmueble { get; set; }
        public DbSet<Venta> Venta { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Inmueble>()
        //        .HasOne(b => b.Venta)
        //        .WithOne(i => i.Inmueble)
        //        .HasForeignKey<Venta>(b => b.InmuebleId);
        //}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
