using DataAPI.Dominio;
using System.Data;
using DataAPI.Datos;
using DataAPI.Servicios.Interfaces;
using DataAPI.Datos.Implementaciones;
using DataAPI.Datos.Interfaces;

namespace DataAPI.Servicios.Implementaciones
{
    public class GestorAPI : IGestorAPI
    {
        private readonly IAyudanteDAO oDAO;

        public GestorAPI()
        {
            oDAO = new AyudanteDAO();
        }

        public async Task<DataTable> Ingreso()
        {
            return await oDAO.Ingreso();
        }
        public async Task<int> AlumnoDarAlta(string apellido, string nombre)
        {
            return await oDAO.AlumnoDarAlta(apellido, nombre);
        }

        public async Task<int> AlumnoDarBaja(string apellido, string nombre)
        {
            return await oDAO.AlumnoDarBaja(apellido, nombre);
        }

        public async Task<List<Alumno>> GetAlumnos()
        {
            return await oDAO.GetAlumnos();
        }

        public async Task<List<AlumnoAltaBaja>> GetAlumnosAlta()
        {
            return await oDAO.GetAlumnosAlta();
        }

        public async Task<List<AlumnoAltaBaja>> GetAlumnosBaja()
        {
            return await oDAO.GetAlumnosBaja();
        }

        public async Task<List<Barrio>> GetBarrios()
        {
            return await oDAO.GetBarrios();
        }

        public async Task<List<EstadoCivil>> GetEstadosCivil()
        {
            return await oDAO.GetEstadosCivil();
        }

        public async Task<int> GetProximoAlumno()
        {
            return await oDAO.GetProximoAlumno();
        }

        public async Task<List<SituacionHab>> GetSituacionHab()
        {
            return await oDAO.GetSituacionHab();
        }

        public async Task<List<SituacionLab>> GetSituacionLab()
        {
            return await oDAO.GetSituacionLab();
        }

        public async Task<List<Tecnicatura>> GetTecnicaturas()
        {
            return await oDAO.GetTecnicaturas();
        }

        public async Task<List<TipoDNI>> GetTiposDNI()
        {
            return await oDAO.GetTiposDNI();
        }
        public async Task<List<Alumno2>> GetAlumnosConAlta()
        {
            return await oDAO.GetAlumnosConAlta();
        }

        public async Task<bool> CrearAlumno(Alumno alumno)
        {
            return await oDAO.CrearAlumno(alumno);
        }

        public async Task<bool> ModificarAlumno(Alumno2 alumno)
        {
            return await oDAO.ModificarAlumno(alumno);
        }

        public async Task<bool> EliminarAlumno(int id)
        {
            return await oDAO.EliminarAlumno(id);
        }

        // ALTA EXAMEN


        public async Task<List<Materia>> GetMaterias()
        {
            return await oDAO.GetMaterias();
        }

        public async Task<List<TipoExamen>> GetTipoExamenes()
        {
            return await oDAO.GetTipoExamenes();
        }
        public async Task<bool> CrearExamen(Examen examen)
        {
            return await oDAO.CrearExamen(examen);
        }
        public async Task<int> GetProximoExamen()
        {
            return await oDAO.GetProximoExamen();
        }

        // FORM PROFESORES

        public async Task<int> GetProximoProfesor()
        {
            return await oDAO.GetProximoProfesor();
        }
        public async Task<List<Profesor>> GetProfesores()
        {
            return await oDAO.GetProfesores();
        }
        public async Task<bool> CrearProfesor(Profesor profesor)
        {
            return await oDAO.CrearProfesor(profesor);
        }

        public async Task<bool> ModificarProfesor(Profesor profesor)
        {
            return await oDAO.ModificarProfesor(profesor);
        }

        public async Task<bool> EliminarProfesor(int id, string nombre, string apellido)
        {
            return await oDAO.EliminarProfesor(id, nombre, apellido);
        }
    }
}
