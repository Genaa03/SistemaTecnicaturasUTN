using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.Dominio
{
    public class Profesor
    {
        public Profesor()
        {
            id_profesor = 0;
            nombreCompleto = "";
            nombre = "";
            apellido = "";
            tipo_dni = 0;
            nro_dni = "";
            fecha_nac = DateTime.Today;
            estado_civil = 0;
            barrio = 0;
            direccion = "";
            titulo_universitario = "";
        }

        public Profesor(int id, string nombreCompleto, string nombre, string apellido, int tipo_dni, string nro_dni, DateTime fecha_nac, int estado_civil, int barrio, string direccion, string titulo_universitario)
        {
            this.id_profesor = id;
            this.nombreCompleto = nombreCompleto;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipo_dni = tipo_dni;
            this.nro_dni = nro_dni;
            this.fecha_nac = fecha_nac;
            this.estado_civil = estado_civil;
            this.barrio = barrio;
            this.direccion = direccion;
            this.titulo_universitario = titulo_universitario;
        }


        public int id_profesor { get; set; }
        public string nombreCompleto { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int tipo_dni { get; set; }
        public string nro_dni { get; set; }
        public DateTime fecha_nac { get; set; }
        public int estado_civil { get; set; }
        public int barrio { get; set; }
        public string direccion { get; set; }
        public string titulo_universitario { get; set; }

        public override string ToString()
        {
            return id_profesor + " - " + nombreCompleto;
        }
    }
}
