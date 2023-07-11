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
        public Task<List<TipoDNI>> GetTiposDNI();
        public Task<int> GetProximoAlumno();
        public Task<List<Tecnicatura>> GetTecnicaturas();
        public Task<List<EstadoCivil>> GetEstadosCivil();
        public Task<List<SituacionHab>> GetSituacionHab();
        public Task<List<SituacionLab>> GetSituacionLab();
        public Task<List<Barrio>> GetBarrios();

        // FORM ALTA/BAJA ALUMNOS

        public Task<List<AlumnoAltaBaja>> GetAlumnosBaja();

        public Task<List<AlumnoAltaBaja>> GetAlumnosAlta();

        public Task<int> AlumnoDarBaja(string apellido, string nombre);

        public Task<int> AlumnoDarAlta(string apellido, string nombre);

        public Task<bool> CrearAlumno(Alumno alumno);
        public Task<bool> ModificarAlumno(Alumno2 alumno);
        public Task<bool> EliminarAlumno(int id);


        // FORM ALTA EXAMEN

        public Task<List<Materia>> GetMaterias();
        public Task<List<TipoExamen>> GetTipoExamenes();
        public Task<bool> CrearExamen(Examen examen);
        public Task<int> GetProximoExamen();

        // FORM PROFESORES

        public Task<int> GetProximoProfesor();
        public Task<List<Profesor>> GetProfesores();
        public Task<bool> CrearProfesor(Profesor profesor);
        public Task<bool> ModificarProfesor(Profesor profesor);
        public Task<bool> EliminarProfesor(int id, string nombre, string apellido);
    }
}
