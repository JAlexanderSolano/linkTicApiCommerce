using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussnies
{
    public class Pedidos
    {
        public DataTable confirmarPedido(string identificacion)
        {
            Data.Pedidos pedidos = new Data.Pedidos();
            DataTable tblResult = pedidos.confirmarPedido(identificacion);
            return tblResult;
        }

        public DataTable listarPedidos(string identificacion)
        {
            Data.Pedidos pedidos = new Data.Pedidos();
            DataTable tblResult = pedidos.listarPedidos(identificacion);
            return tblResult;
        }

        public DataTable listarPedidosPagados(string identificacion)
        {
            Data.Pedidos pedidos = new Data.Pedidos();
            DataTable tblResult = pedidos.listarPedidosPagados(identificacion);
            return tblResult;
        }

        public DataTable registrarPedido(string id_producto, string identificacion)
        {
            Data.Pedidos pedidos = new Data.Pedidos();
            DataTable tblResult = pedidos.registrarPedido(id_producto, identificacion);
            return tblResult;

        }
    }
}
