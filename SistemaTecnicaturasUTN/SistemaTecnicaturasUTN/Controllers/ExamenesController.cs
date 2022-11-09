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
    public class ExamenesController : ControllerBase
    {
        private IGestorAPI gestor;

        public ExamenesController()
        {
            gestor = new GestorAPI();
        }


        [HttpGet("/materias")]
        public IActionResult GetMaterias()
        {
            try
            {
                List<Materia> lst = gestor.GetMaterias();
                return Ok(lst);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/tipoExamenes")]
        public IActionResult GetTipoExamenes()
        {
            try
            {
                List<TipoExamen> lst = gestor.GetTipoExamenes();
                return Ok(lst);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        [HttpPost("/crearExamen")]
        public IActionResult PostExamen(Examen examen)
        {
            try
            {
                if (examen == null)
                {
                    return BadRequest("Datos del examen incorrectos!");
                }

                return Ok(gestor.CrearExamen(examen));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

    }
}
