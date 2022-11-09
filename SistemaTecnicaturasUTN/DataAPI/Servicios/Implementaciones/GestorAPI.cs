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

        public DataTable Ingreso()
        {
            return oDAO.Ingreso();
        }
        public int AlumnoDarAlta(string apellido, string nombre)
        {
            return oDAO.AlumnoDarAlta(apellido, nombre);
        }

        public int AlumnoDarBaja(string apellido, string nombre)
        {
            return oDAO.AlumnoDarBaja(apellido, nombre);
        }

        public List<Alumno> GetAlumnos()
        {
            return oDAO.GetAlumnos();
        }

        public List<AlumnoAltaBaja> GetAlumnosAlta()
        {
            return oDAO.GetAlumnosAlta();
        }

        public List<AlumnoAltaBaja> GetAlumnosBaja()
        {
            return oDAO.GetAlumnosBaja();
        }

        public List<Barrio> GetBarrios()
        {
            return oDAO.GetBarrios();
        }

        public List<EstadoCivil> GetEstadosCivil()
        {
            return oDAO.GetEstadosCivil();
        }

        public int GetProximoAlumno()
        {
            return oDAO.GetProximoAlumno();
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
        public List<Alumno2> GetAlumnosConAlta()
        {
            return oDAO.GetAlumnosConAlta();
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

        public int GetProximoProfesor()
        {
            return oDAO.GetProximoProfesor();
        }
        public List<Profesor> GetProfesores()
        {
            return oDAO.GetProfesores();
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
