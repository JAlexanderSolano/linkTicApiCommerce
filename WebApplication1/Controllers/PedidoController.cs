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
    public class PedidoController : ControllerBase
    {
        private readonly Ipedidos _pedidos;
        private readonly Iresultado _resultado;
        public PedidoController(Ipedidos pedido, Iresultado resultado)
        {
            _pedidos = pedido;
            _resultado = resultado;
        }
        /// <summary>
        /// Lista los pedidos del cliente agregados al carrito de compras
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public IActionResult ListarPedidos([FromBody] ObtenerPedido objp)
        {
            try
            {
                List<Entities.pedidos> lsResult = new List<pedidos>();
                Bussnies.Pedidos pedidos = new Bussnies.Pedidos();
                DataTable tblResult = pedidos.listarPedidos(objp.identificacion);

                lsResult = _pedidos.RetornarResultado(tblResult);
                
                return Ok(lsResult);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + ex.StackTrace);
            }
        }
        /// <summary>
        /// lista todos los pedidos pagados por el cliente en el dia presente
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public IActionResult ListarPedidosPagados([FromBody] ObtenerPedido objp)
        {
            try
            {
                List<Entities.pedidos> lsResult = new List<pedidos>();
                Bussnies.Pedidos pedidos = new Bussnies.Pedidos();
                DataTable tblResult = pedidos.listarPedidosPagados(objp.identificacion);

                lsResult = _pedidos.RetornarResultado(tblResult);

                return Ok(lsResult);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + ex.StackTrace);
            }
        }
        /// <summary>
        /// Registra el pedido de cliente en el carrito de compras
        /// </summary>
        /// <returns></returns>
        [HttpPost("[action]")]
        public IActionResult RegistrarPedido([FromBody] RegistrarPedido regped)
        {
            try
            {
                List<Entities.resultado> lsResultado = new List<resultado>();
                Bussnies.Pedidos pedidos = new Bussnies.Pedidos();
                DataTable tblResult = pedidos.registrarPedido(regped.id_producto, regped.identificacion);

                lsResultado = _resultado.RetornarResultado(tblResult);
                return Ok(lsResultado);

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message + ex.StackTrace);
            }
        }
        /// <summary>
        /// Confirma el pedido y procede con el pago del mismo.
        /// </summary>
        /// <returns></returns>
        [HttpPost("[action]")]
        public IActionResult ConfirmarPedido([FromBody] ConfirmarPedido confped)
        {
            try
            {
                List<Entities.resultado> lsResultado = new List<resultado>();
                Bussnies.Pedidos pedidos = new Bussnies.Pedidos();
                DataTable tblResult = pedidos.confirmarPedido(confped.identificacion);

                lsResultado = _resultado.RetornarResultado(tblResult);
                return Ok(lsResultado);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + ex.StackTrace);
            }
        }
    }
}
