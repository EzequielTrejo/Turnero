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
        public string Cliente { get; set; }
        public string Servicio { get; set; }
        public int CostoServicio { get; set; }
    }
}
