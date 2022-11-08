using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.Dominio
{
    public class Alumno2
    {
        public Alumno2()
        {
            id = 0;
            nombreCompleto = "";
            nombre = "";
            apellido = "";
            tipo_dni = 0;
            nro_dni = "";
            tecnicatura = 0;
            fecha_nac = DateTime.Today;
            estado_civil = 0;
            situacion_laboral = 0;
            situacion_habitacional = 0;
            barrio = 0;
            direccion = "";
        }

        public Alumno2(int id, string nombreCompleto, string nombre, string apellido, int tipo_dni, string nro_dni, int tecnicatura, DateTime fecha_nac, int estado_civil, int situacion_laboral, int situacion_habitacional, int barrio, string direccion)
        {
            this.id = id;
            this.nombreCompleto = nombreCompleto;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipo_dni = tipo_dni;
            this.nro_dni = nro_dni;
            this.tecnicatura = tecnicatura;
            this.fecha_nac = fecha_nac;
            this.estado_civil = estado_civil;
            this.situacion_laboral = situacion_laboral;
            this.situacion_habitacional = situacion_habitacional;
            this.barrio = barrio;
            this.direccion = direccion;
        }


        public int id { get; set; }
        public string nombreCompleto { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int tipo_dni { get; set; }
        public string nro_dni { get; set; }
        public int tecnicatura { get; set; }
        public DateTime fecha_nac { get; set; }
        public int estado_civil { get; set; }
        public int situacion_laboral { get; set; }
        public int situacion_habitacional { get; set; }
        public int barrio { get; set; }
        public string direccion { get; set; }

        public override string ToString()
        {
            return id + " - " + nombreCompleto;
        }
    }
}
