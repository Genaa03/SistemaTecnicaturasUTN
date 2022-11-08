using DataAPI.Dominio;
using System.Data;

namespace DataAPI.Servicios.Interfaces
{
    public interface IGestorAPI
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


        // FORM ALTA EXAMEN

        public bool CrearExamen(Examen examen);
    }
}
