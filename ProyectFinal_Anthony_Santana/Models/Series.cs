using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectFinal_Anthony_Santana.Models
{
    public class Series
    {
        [Key]
        public int SeriesId { get; set; }

        public string Titulo { get; set; }

        public string Genero { get; set; }

        public int Existencia { get; set; }

        public int Duracion { get; set; }

        public double Precio { get; set; }

        public Series()
        {

        }
    }
    
}