using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.Dominio
{
    public class Barrio
    {
        public Barrio(int id, string barrio)
        {
            this.id = id;
            this.barrio = barrio;
        }

        public int id { get; set; }
        public string barrio { get; set; }
    }
}
