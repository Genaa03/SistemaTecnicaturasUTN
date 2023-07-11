using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.Dominio
{
    public class Alumno
    {
        public Alumno()
        {
            Id = 0;
            Nombre = "";
            Apellido = "";
            Tipo_dni = 0;
            Nro_dni = "";
            Tecnicatura = 0;
            Fecha_nac = DateTime.Today;
            Estado_civil = 0;
            Situacion_laboral = 0;
            Situacion_habitacional = 0;
            Barrio = 0;
            Direccion = "";
        }

        public Alumno(int id, string nombre, string apellido, int tipo_dni, string nro_dni, int tecnicatura, DateTime fecha_nac, int estado_civil, int situacion_laboral, int situacion_habitacional, int barrio, string direccion)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Tipo_dni = tipo_dni;
            this.Nro_dni = nro_dni;
            this.Tecnicatura = tecnicatura;
            this.Fecha_nac = fecha_nac;
            this.Estado_civil = estado_civil;
            this.Situacion_laboral = situacion_laboral;
            this.Situacion_habitacional = situacion_habitacional;
            this.Barrio = barrio;
            this.Direccion = direccion;
        }


        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Tipo_dni { get; set; }
        public string Nro_dni { get; set; }
        public int Tecnicatura { get; set; }
        public DateTime Fecha_nac { get; set; }
        public int Estado_civil { get; set; }
        public int Situacion_laboral { get; set; }
        public int Situacion_habitacional { get; set; }
        public int Barrio { get; set; }
        public string Direccion { get; set; }

        public override string ToString()
        {
            return Id + " - " + Apellido + ", " + Nombre;
        }
    }
}
