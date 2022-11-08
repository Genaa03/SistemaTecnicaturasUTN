using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.Dominio
{
    public class SituacionHab
    {
        public SituacionHab(int id, string situacion_hab)
        {
            this.id = id;
            this.situacion_hab = situacion_hab;
        }

        public int id { get; set; }
        public string situacion_hab { get; set; }
    }
}
