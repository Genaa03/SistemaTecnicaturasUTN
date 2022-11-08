using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.Dominio
{
    public class AlumnoAltaBaja
    {
        public AlumnoAltaBaja(string apellido, string nombre)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public string apellido { get; set; }
        public string nombre { get; set; }
    }
}
