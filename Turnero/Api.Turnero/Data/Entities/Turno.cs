using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Turnero.Data.Entities
{
    public class Turno
    {
        public int Id{ get; set; }
        public DateTime Fecha { get; set; }
        public int Id_Cliente { get; set; } //clave foranea
        [ForeignKey("Id_Cliente")]
        public Cliente Cliente { get; set; }
        

        public float CostoServicio { get; set; }
        public int Tipo_Servicio { get; set; }
        [ForeignKey("Tipo_Servicio")]
        public Servicio Servicio { get; set; }



    }
}
