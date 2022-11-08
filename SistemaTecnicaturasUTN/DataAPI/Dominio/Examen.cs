using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.Dominio
{
    public class Examen
    {

        public int tipo_examen { get; set; }
        public int materia { get; set; }
        public DateTime fecha { get; set; }

        public List<DetalleExamen> examenes { get; set; }

        public Examen(List<DetalleExamen> examenes)
        {
            this.examenes = examenes;
        }

        public void AgregarExamen(DetalleExamen examen)
        {
            examenes.Add(examen);
        }

        public void QuitarExamen(int indice)
        {
            examenes.RemoveAt(indice);
        }
    }
}
