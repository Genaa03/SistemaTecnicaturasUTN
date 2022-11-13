using DataAPI.Dominio;
using System.Data;

namespace DataAPI.Servicios.Interfaces
{
    public interface IGestorAPI
    {
        public Task<DataTable> Ingreso();

        // FORM INSCRIPCION ALUMNOS

        public Task<List<Alumno>> GetAlumnos();
        public Task<List<Alumno2>> GetAlumnosConAlta();
        public List<TipoDNI> GetTiposDNI();
        public int GetProximoAlumno();
        public List<Tecnicatura> GetTecnicaturas();
        public List<EstadoCivil> GetEstadosCivil();
        public List<SituacionHab> GetSituacionHab();
        public List<SituacionLab> GetSituacionLab();
        public List<Barrio> GetBarrios();

        // FORM ALTA/BAJA ALUMNOS

        public Task<List<AlumnoAltaBaja>> GetAlumnosBaja();

        public Task<List<AlumnoAltaBaja>> GetAlumnosAlta();

        public int AlumnoDarBaja(string apellido, string nombre);

        public int AlumnoDarAlta(string apellido, string nombre);

        public bool CrearAlumno(Alumno alumno);
        public bool ModificarAlumno(Alumno2 alumno);
        public bool EliminarAlumno(int id, string nombre, string apellido);


        // FORM ALTA EXAMEN

        public List<Materia> GetMaterias();
        public List<TipoExamen> GetTipoExamenes();
        public bool CrearExamen(Examen examen);
        public int GetProximoExamen();

        // FORM PROFESORES

        public int GetProximoProfesor();
        public Task<List<Profesor>> GetProfesores();
        public bool CrearProfesor(Profesor profesor);
        public bool ModificarProfesor(Profesor profesor);
        public bool EliminarProfesor(int id, string nombre, string apellido);
    }
}
