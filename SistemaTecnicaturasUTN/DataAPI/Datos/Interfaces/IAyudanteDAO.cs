using DataAPI.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.Datos.Interfaces
{
    internal interface IAyudanteDAO
    {
        // FORM INSCRIPCION ALUMNOS

        public List<Alumno> GetAlumnos();
        public List<Alumno2> GetAlumnosConAlta();
        public List<TipoDNI> GetTiposDNI();
        public int GetProximoAlumno();
        public List<Tecnicatura> GetTecnicaturas();
        public List<EstadoCivil> GetEstadosCivil();
        public List<SituacionHab> GetSituacionHab();
        public List<SituacionLab> GetSituacionLab();
        public List<Barrio> GetBarrios();

        // FORM ALTA/BAJA ALUMNOS

        public List<AlumnoAltaBaja> GetAlumnosBaja();

        public List<AlumnoAltaBaja> GetAlumnosAlta();

        public int AlumnoDarBaja(string apellido, string nombre);

        public int AlumnoDarAlta(string apellido, string nombre);

        public bool CrearAlumno(Alumno alumno);

        public bool ModificarAlumno(Alumno2 alumno);

        public bool EliminarAlumno(int id, string nombre, string apellido);

        // FORM EXAMEN

        public List<Materia> GetMaterias();
        public List<TipoExamen> GetTipoExamenes();
        public bool CrearExamen(Examen examen);

        public int GetProximoExamen();

    }
}
