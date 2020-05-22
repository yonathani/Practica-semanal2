using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Practica_semanal2.Models
{
    public class Cita
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Tipo_cafe { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public string Status { get; set; }
    }
}