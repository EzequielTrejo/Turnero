using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Turnero.Data.Entities
{
    public class Servicio
    {
        public int Id { get; set; }
        public Tipo Tipo_Servicio { get; set; }
       

        //Tipo_Servicio= 1 Corte/ 2 Lavado
        public enum Tipo
        {
            Corte = 1,
            Lavado = 2,
            Tintura = 3,
            Nada = 4
        };
    }
}
