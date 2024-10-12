using Datos.entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AppDbContext : DbContext
    {
        public DbSet<Obra> Obras { get; set; }
        public DbSet<Personaje> Personajes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Obra>()
                .HasMany(o => o.Personajes)
                .WithOne(p => p.Obra)
                .HasForeignKey(p => p.ObraId);
        }
    }
}
