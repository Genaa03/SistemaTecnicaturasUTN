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

        // ALTA EXAMEN

        public bool CrearExamen(Examen examen)
        {
            return oDAO.CrearExamen(examen);
        }

        public bool CrearAlumno(Alumno alumno)
        {
            return oDAO.CrearAlumno(alumno);
        }

        public List<Alumno2> GetAlumnosConAlta()
        {
            return oDAO.GetAlumnosConAlta();
        }
    }
}
