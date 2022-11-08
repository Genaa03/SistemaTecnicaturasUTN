using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.Dominio
{
    public class TipoDNI
    {
        public TipoDNI(int id, string tipo_dni)
        {
            this.id = id;
            this.tipo_dni = tipo_dni;
        }

        public int id { get; set; }
        public string tipo_dni { get; set; }
    }
}
