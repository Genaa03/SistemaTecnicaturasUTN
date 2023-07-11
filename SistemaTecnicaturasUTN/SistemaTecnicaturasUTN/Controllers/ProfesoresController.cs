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
    public class ProfesoresController : ControllerBase
    {
        private readonly IGestorAPI gestor;

        public ProfesoresController()
        {
            gestor = new GestorAPI();
        }


        [HttpGet("/profesores")]
        public async Task<IActionResult> GetProfesores()
        {
            try
            {
                List<Profesor> lst = await gestor.GetProfesores();
                return Ok(lst);

            }
            catch
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPost("/inscripcionProfesor")]
        public async Task<IActionResult> PostProfesor(Profesor profesor)
        {
            try
            {
                if (profesor == null)
                {
                    return BadRequest("Datos del profesor incorrectos!");
                }

                return Ok(await gestor.CrearProfesor(profesor));
            }
            catch
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPut("/modificacionProfesor")]
        public async Task<IActionResult> PutProfesor(Profesor profesor)
        {
            try
            {
                if (profesor == null)
                {
                    return BadRequest("Datos del profesor incorrectos!");
                }

                return Ok(await gestor.ModificarProfesor(profesor));
            }
            catch
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpDelete("/eliminacionProfesor")]
        public async Task<IActionResult> DeleteProfesor(int id, string nombre, string apellido)
        {

            try
            {
                if (String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(apellido))
                {
                    return BadRequest("Datos del profesor incorrectos!");
                }

                return Ok(await gestor.EliminarProfesor(id, nombre, apellido));

            }
            catch
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

    }
}
