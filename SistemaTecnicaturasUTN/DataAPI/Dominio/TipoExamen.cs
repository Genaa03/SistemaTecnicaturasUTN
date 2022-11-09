using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.Dominio
{
    public class TipoExamen
    {
        public TipoExamen(int id, string tipo_examen)
        {
            this.id = id;
            this.tipo_examen = tipo_examen;
        }

        public int id { get; set; }
        public string tipo_examen { get; set; }
    }
}
