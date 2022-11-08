using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.Dominio
{
    public class EstadoCivil
    {
        public EstadoCivil(int id, string estado_civil)
        {
            this.id = id;
            this.estado_civil = estado_civil;
        }

        public int id { get; set; }
        public string estado_civil { get; set; }
    }
}
