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
        public async Task<IActionResult> GetAlumnos()
        {
            try
            {
                List<Alumno> lst = await gestor.GetAlumnos();
                return Ok(lst);

            }
            catch
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/alumnosConAlta")]
        public async Task<IActionResult> GetAlumnosConAlta()
        {
            try
            {
                List<Alumno2> lst = await gestor.GetAlumnosConAlta();
                return Ok(lst);

            }
            catch
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/barrios")]
        public async Task<IActionResult> GetBarrios()
        {
            
            try
            {
                List<Barrio> tabla = await gestor.GetBarrios();
                return Ok(tabla);

            }
            catch
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/tiposDNI")]
        public async Task<IActionResult> GetTiposDNI()
        {

            try
            {
                List<TipoDNI> tabla = await gestor.GetTiposDNI();
                return Ok(tabla);

            }
            catch
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/tecnicaturas")]
        public async Task<IActionResult> GetTecnicaturas()
        {

            try
            {
                List<Tecnicatura> tabla = await gestor.GetTecnicaturas();
                return Ok(tabla);

            }
            catch
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/situacionHab")]
        public async Task<IActionResult> GetSituacionesHab()
        {

            try
            {
                List<SituacionHab> tabla = await gestor.GetSituacionHab();
                return Ok(tabla);

            }
            catch
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/situacionLab")]
        public async Task<IActionResult> GetSituacionesLab()
        {

            try
            {
                List<SituacionLab> tabla = await gestor.GetSituacionLab();
                return Ok(tabla);

            }
            catch
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/estadosCivil")]
        public async Task<IActionResult> GetEstadosCivil()
        {

            try
            {
                List<EstadoCivil> tabla = await gestor.GetEstadosCivil();
                return Ok(tabla);

            }
            catch (Exception e)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/proximoAlumno")]
        public async Task<IActionResult> GetProximoAlumno()
        {

            try
            {
                int num = await gestor.GetProximoAlumno();
                return Ok(num);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/alumnosAlta")]
        public async Task<IActionResult> GetAlumnosAlta()
        {

            try
            {
                List<AlumnoAltaBaja> num = await gestor.GetAlumnosAlta();
                return Ok(num);

            }
            catch
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/alumnosBaja")]
        public async Task<IActionResult> GetAlumnosBaja()
        {

            try
            {
                List<AlumnoAltaBaja> num = await gestor.GetAlumnosBaja();
                return Ok(num);

            }
            catch
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        [HttpPost("/inscripcionAlumno")]
        public async Task<IActionResult> PostAlumno(Alumno alumno)
        {
            try
            {
                if (alumno == null)
                {
                    return BadRequest("Datos del alumno incorrectos!");
                }

                return Ok(await gestor.CrearAlumno(alumno));
            }
            catch
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPut("/modificacionAlumno")]
        public async Task<IActionResult> PutAlumno(Alumno2 alumno)
        {
            try
            {
                if (alumno == null)
                {
                    return BadRequest("Datos del alumno incorrectos!");
                }

                return Ok(await gestor.ModificarAlumno(alumno));
            }
            catch
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpDelete("/eliminacionAlumno/{id}")]
        public async Task<IActionResult> DeleteAlumno(int id)
        {

            try
            {

                return Ok(await gestor.EliminarAlumno(id));

            }
            catch
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
    }
}
