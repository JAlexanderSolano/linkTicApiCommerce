using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Pedidos
    {
        public DataTable confirmarPedido(string identificacion)
        {
            string Query = String.Format("exec [dbo].[sp_ConfirmarPago] '{0}'", identificacion);
            DataTable tblResult = Conexion.Consultar(Query);
            return tblResult;
        }

        public DataTable listarPedidos(string identificacion)
        {
            string Query = String.Format("EXEC [dbo].[sp_ObtenerPedido] '{0}'", identificacion);
            DataTable tblResult = Conexion.Consultar(Query);
            return tblResult;
        }

        public DataTable listarPedidosPagados(string identificacion)
        {
            string Query = String.Format("EXEC [dbo].[sp_ObtenerPedidoPagado] '{0}'", identificacion);
            DataTable tblResult = Conexion.Consultar(Query);
            return tblResult;
        }

        public DataTable registrarPedido(string id_producto, string identificacion)
        {
            string Query = String.Format("exec [dbo].[sp_GenerarPedido] {0},'{1}'", id_producto,identificacion);
            DataTable tblResult = Conexion.Consultar(Query);
            return tblResult;
        }
    }
}
