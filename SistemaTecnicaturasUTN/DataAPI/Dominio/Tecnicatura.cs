using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.Dominio
{
    public class Tecnicatura
    {
        public Tecnicatura(int id, string tecnicatura)
        {
            this.id = id;
            this.tecnicatura = tecnicatura;
        }

        public int id { get; set; }
        public string tecnicatura { get; set; }
    }
}
