using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.Dominio
{
    public class DetalleExamen
    {
        public DetalleExamen(Alumno2 alumno, double nota)
        {
            this.alumno = alumno;
            this.nota = nota;
        }

        public Alumno2 alumno { get; set; }
        public double nota { get; set; }
        
    }
}
