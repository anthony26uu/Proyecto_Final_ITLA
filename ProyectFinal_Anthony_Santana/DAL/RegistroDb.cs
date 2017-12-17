
using ProyectFinal_Anthony_Santana.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProyectoFinal_Anthony_Santana.DAL
{
    public class RegistroDb : DbContext
    {

        public RegistroDb() : base("ConStr")
        {

        }
        
        public DbSet<Clientes> clientedb { get; set; }
        public DbSet<FacturasDetalles> facturaDetalledb { get; set; }
        public DbSet<Peliculas> peliculadb { get; set; }
        public DbSet<Facturas>  facturadb { get; set; }
        public DbSet<Series> seriesdb { get; set; }

    }
}