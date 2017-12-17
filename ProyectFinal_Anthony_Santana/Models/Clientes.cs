﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace  ProyectFinal_Anthony_Santana.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }

        public string Nombres { get; set; }

        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public Clientes()
        {

        }
    }
}