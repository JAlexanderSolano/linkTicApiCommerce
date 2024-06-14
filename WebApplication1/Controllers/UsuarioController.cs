using Interface;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly Iresultado _resultado;
        public UsuarioController(Iresultado resultado) 
        {
            _resultado= resultado;
        }

        /// <summary>
        /// Registra el usuario en la base de datos
        /// </summary>
        /// <returns></returns>
        [HttpPost("[action]")]
        public IActionResult Registrar([FromBody] Registrarme reg)
        {
           
            try
            {
                
                Bussnies.Registrar registrar = new Bussnies.Registrar();
                List<Entities.resultado> lsResult = new List<Entities.resultado>();

                DataTable tbllResult = registrar.Registrarme(reg.nombre, reg.identificacion, reg.telefono, reg.email, reg.usuario, reg.contrasena);

                lsResult = _resultado.RetornarResultado(tbllResult);
                return Ok(lsResult);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.StackTrace + ex.Message);
            }
        }
    }
}
