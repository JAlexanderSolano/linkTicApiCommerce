using Entities;
using Interface;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly Iproducto _producto;
        private readonly Iresultado _resultado;
        public ProductoController(Iproducto producto, Iresultado resultado )
        {
            _producto = producto;
            _resultado = resultado;
        }
        /// <summary>
        /// Obtiene todos los productos al sistema para su posterior venta
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public IActionResult ListarProductos()
        {
            try
            {
                List<Entities.producto> lsResult = new List<Entities.producto>();
                Bussnies.Productos productos = new Bussnies.Productos();
                DataTable tblResult = productos.listarProductos();
                lsResult = _producto.RetornarResultado(tblResult);

                return Ok(lsResult);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + ex.StackTrace);
            }
        }
        /// <summary>
        /// Registra los productos que se disponen para vender
        /// </summary>
        /// <returns></returns>
        [HttpPost("[action]")]
        public IActionResult RegistrarProductos([FromBody] RegistrarProducto prod)
        {
            try
            {
                List<Entities.resultado> lsResult = new List<resultado>();
                Bussnies.Productos productos = new Bussnies.Productos();
                DataTable tblResult = productos.RegistrarProductos(prod.nombre, prod.cantidad, prod.precio);
                lsResult = _resultado.RetornarResultado(tblResult);

                return Ok(lsResult);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + ex.StackTrace);
            }
        }

    }
}
