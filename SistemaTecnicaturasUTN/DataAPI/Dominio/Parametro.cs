using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.Dominio
{
    public class Parametro
    {
        public Parametro(string clave, object valor)
        {
            Clave = clave;
            Valor = valor;
        }

        public string Clave { get; set; }
        public object Valor { get; set; }


    }
}
