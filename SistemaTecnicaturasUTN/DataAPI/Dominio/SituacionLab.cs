using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.Dominio
{
    public class SituacionLab
    {
        public SituacionLab(int id, string situacion_lab)
        {
            this.id = id;
            this.situacion_lab = situacion_lab;
        }

        public int id { get; set; }
        public string situacion_lab { get; set; }
    }
}
