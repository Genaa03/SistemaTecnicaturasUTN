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

        public Examen()
        {
            examenes = new List<DetalleExamen>();
        }

        public void AgregarExamen(DetalleExamen examen)
        {
            examenes.Add(examen);
        }

        public void QuitarExamen(int indice)
        {
            examenes.RemoveAt(indice);
        }

        public double CalcularPromedio()
        {
            double total = 0;
            double promedio = 0;
            foreach (DetalleExamen item in examenes)
                total += item.nota;
            promedio = total / examenes.Count;
            return Math.Round(promedio,2);
        }
    }
}
