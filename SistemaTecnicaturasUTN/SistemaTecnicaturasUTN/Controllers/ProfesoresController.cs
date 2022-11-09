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
        private IGestorAPI gestor;

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
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPost("/inscripcionProfesor")]
        public IActionResult PostProfesor(Profesor profesor)
        {
            try
            {
                if (profesor == null)
                {
                    return BadRequest("Datos del profesor incorrectos!");
                }

                return Ok(gestor.CrearProfesor(profesor));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPut("/modificacionProfesor")]
        public IActionResult PutProfesor(Profesor profesor)
        {
            try
            {
                if (profesor == null)
                {
                    return BadRequest("Datos del profesor incorrectos!");
                }

                return Ok(gestor.ModificarProfesor(profesor));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpDelete("/eliminacionProfesor")]
        public IActionResult DeleteProfesor(int id, string nombre, string apellido)
        {

            try
            {
                if (String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(apellido))
                {
                    return BadRequest("Datos del profesor incorrectos!");
                }

                return Ok(gestor.EliminarProfesor(id, nombre, apellido));

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

    }
}
