using DataAPI.Dominio;
using DataAPI.Servicios.Implementaciones;
using DataAPI.Servicios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace SistemaTecnicaturasUTN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        private IGestorAPI gestor;

        public AlumnosController()
        {
            gestor = new GestorAPI();
        }

        [HttpGet("/alumnos")]
        public IActionResult GetAlumnos()
        {
            try
            {
                List<Alumno> lst = gestor.GetAlumnos();
                return Ok(lst);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/alumnosConAlta")]
        public IActionResult GetAlumnosConAlta()
        {
            try
            {
                List<Alumno2> lst = gestor.GetAlumnosConAlta();
                return Ok(lst);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/barrios")]
        public IActionResult GetBarrios()
        {
            
            try
            {
                List<Barrio> tabla = gestor.GetBarrios();
                return Ok(tabla);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/tiposDNI")]
        public IActionResult GetTiposDNI()
        {

            try
            {
                List<TipoDNI> tabla = gestor.GetTiposDNI();
                return Ok(tabla);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/tecnicaturas")]
        public IActionResult GetTecnicaturas()
        {

            try
            {
                List<Tecnicatura> tabla = gestor.GetTecnicaturas();
                return Ok(tabla);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/situacionHab")]
        public IActionResult GetSituacionesHab()
        {

            try
            {
                List<SituacionHab> tabla = gestor.GetSituacionHab();
                return Ok(tabla);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/situacionLab")]
        public IActionResult GetSituacionesLab()
        {

            try
            {
                List<SituacionLab> tabla = gestor.GetSituacionLab();
                return Ok(tabla);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/estadosCivil")]
        public IActionResult GetEstadosCivil()
        {

            try
            {
                List<EstadoCivil> tabla = gestor.GetEstadosCivil();
                return Ok(tabla);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/proximoAlumno")]
        public IActionResult GetProximoAlumno()
        {

            try
            {
                int num = gestor.GetProximoAlumno();
                return Ok(num);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/alumnosAlta")]
        public IActionResult GetAlumnosAlta()
        {

            try
            {
                List<AlumnoAltaBaja> num = gestor.GetAlumnosAlta();
                return Ok(num);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/alumnosBaja")]
        public IActionResult GetAlumnosBaja()
        {

            try
            {
                List<AlumnoAltaBaja> num = gestor.GetAlumnosBaja();
                return Ok(num);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        [HttpPost("/inscripcionAlumno")]
        public IActionResult PostAlumno(Alumno alumno)
        {
            try
            {
                if (alumno == null)
                {
                    return BadRequest("Datos del alumno incorrectos!");
                }

                return Ok(gestor.CrearAlumno(alumno));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPut("/modificacionAlumno")]
        public IActionResult PutAlumno(Alumno2 alumno)
        {
            try
            {
                if (alumno == null)
                {
                    return BadRequest("Datos del alumno incorrectos!");
                }

                return Ok(gestor.ModificarAlumno(alumno));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpDelete("/eliminacionAlumno")]
        public IActionResult DeleteAlumno(int id, string nombre, string apellido)
        {

            try
            {
                if (String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(apellido))
                {
                    return BadRequest("Datos del alumno incorrectos!");
                }

                return Ok(gestor.EliminarAlumno(id,nombre,apellido));

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
    }
}
