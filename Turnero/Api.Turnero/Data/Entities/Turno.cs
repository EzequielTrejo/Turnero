using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Turnero.Data.Entities
{
    public class Turno
    {
        public int Id_Turno { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Id_Cliente { get; set; }
        public float CostoServicio { get; set; }
        public Servicio Id_Servicio;
    }
}
