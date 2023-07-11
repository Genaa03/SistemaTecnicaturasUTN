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
        public async Task<IActionResult> GetMaterias()
        {
            try
            {
                List<Materia> lst = await gestor.GetMaterias();
                return Ok(lst);

            }
            catch
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/tipoExamenes")]
        public async Task<IActionResult> GetTipoExamenes()
        {
            try
            {
                List<TipoExamen> lst = await gestor.GetTipoExamenes();
                return Ok(lst);

            }
            catch
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        [HttpPost("/crearExamen")]
        public async Task<IActionResult> PostExamen(Examen examen)
        {
            try
            {
                if (examen == null)
                {
                    return BadRequest("Datos del examen incorrectos!");
                }

                return Ok(await gestor.CrearExamen(examen));
            }
            catch
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

    }
}
