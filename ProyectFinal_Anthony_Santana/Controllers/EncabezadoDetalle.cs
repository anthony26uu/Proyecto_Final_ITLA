using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectFinal_Anthony_Santana.Models
{
    public class EncabezadoDetalle
    {
        public Facturas Encabezado { get; set; }

        public List<FacturasDetalles> Detalle { get; set; }

        public EncabezadoDetalle()
        {
            Detalle = new List<FacturasDetalles>();
        }
    }
}