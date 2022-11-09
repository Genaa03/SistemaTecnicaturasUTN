using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.Dominio
{
    public class Materia
    {
        public Materia(int id, string materia, int tecnicatura)
        {
            this.id = id;
            this.materia = materia;
            this.tecnicatura = tecnicatura;
        }

        public int id { get; set; }
        public string materia { get; set; }
        public int tecnicatura { get; set; }
    }
}
