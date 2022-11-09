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
        private IAyudanteDAO oDAO;

        public GestorAPI()
        {
            oDAO = new AyudanteDAO();
        }

        public async Task<DataTable> Ingreso()
        {
            return await oDAO.Ingreso();
        }
        public int AlumnoDarAlta(string apellido, string nombre)
        {
            return oDAO.AlumnoDarAlta(apellido, nombre);
        }

        public int AlumnoDarBaja(string apellido, string nombre)
        {
            return oDAO.AlumnoDarBaja(apellido, nombre);
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

        public List<Barrio> GetBarrios()
        {
            return oDAO.GetBarrios();
        }

        public List<EstadoCivil> GetEstadosCivil()
        {
            return oDAO.GetEstadosCivil();
        }

        public async Task<int> GetProximoAlumno()
        {
            return await oDAO.GetProximoAlumno();
        }

        public List<SituacionHab> GetSituacionHab()
        {
            return oDAO.GetSituacionHab();
        }

        public List<SituacionLab> GetSituacionLab()
        {
            return oDAO.GetSituacionLab();
        }

        public List<Tecnicatura> GetTecnicaturas()
        {
            return oDAO.GetTecnicaturas();
        }

        public List<TipoDNI> GetTiposDNI()
        {
            return oDAO.GetTiposDNI();
        }
        public async Task<List<Alumno2>> GetAlumnosConAlta()
        {
            return await oDAO.GetAlumnosConAlta();
        }

        public bool CrearAlumno(Alumno alumno)
        {
            return oDAO.CrearAlumno(alumno);
        }

        public bool ModificarAlumno(Alumno2 alumno)
        {
            return oDAO.ModificarAlumno(alumno);
        }

        public bool EliminarAlumno(int id, string nombre, string apellido)
        {
            return oDAO.EliminarAlumno(id,nombre,apellido);
        }

        // ALTA EXAMEN


        public List<Materia> GetMaterias()
        {
            return oDAO.GetMaterias();
        }

        public List<TipoExamen> GetTipoExamenes()
        {
            return oDAO.GetTipoExamenes();
        }
        public bool CrearExamen(Examen examen)
        {
            return oDAO.CrearExamen(examen);
        }
        public int GetProximoExamen()
        {
            return oDAO.GetProximoExamen();
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
        public bool CrearProfesor(Profesor profesor)
        {
            return oDAO.CrearProfesor(profesor);
        }

        public bool ModificarProfesor(Profesor profesor)
        {
            return oDAO.ModificarProfesor(profesor);
        }

        public bool EliminarProfesor(int id, string nombre, string apellido)
        {
            return oDAO.EliminarProfesor(id, nombre, apellido);
        }
    }
}
