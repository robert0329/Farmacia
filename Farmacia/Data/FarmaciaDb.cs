using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Farmacia.Models;

namespace Farmacia.Models
{
    public class FarmaciaDb : DbContext
    {
        public FarmaciaDb (): base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = ROBERT\\SERVER;Initial Catalog = Farmacias; Integrated Security = True; Connect Timeout = 15; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        public DbSet<Farmacia.Models.Laboratorios> Laboratorios { get; set; }
        public DbSet<Farmacia.Models.Medicinas> Medicinas { get; set; }
        public DbSet<Farmacia.Models.Categorias> Categorias { get; set; }
        public DbSet<Farmacia.Models.TipoVentas> TipoVentas { get; set; }
        public DbSet<Farmacia.Models.Ventas> Ventas { get; set; }
        public DbSet<Farmacia.Models.VentasDetalle> VentasDetalle { get; set; }
    }
    
}
