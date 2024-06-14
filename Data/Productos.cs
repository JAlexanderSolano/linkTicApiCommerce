using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Productos
    {
        public DataTable listarProductos()
        {
            string Query = String.Format("select id, nombre, cantidad, format(cast(precio as int), 'C', 'en-co') as precio from Tb_Productos");
            DataTable tblResult = Conexion.Consultar(Query);
            return tblResult;
        }

        public DataTable RegistrarProductos(string nombre, string cantidad, string precio)
        {
            string Query = String.Format("exec [dbo].[sp_RegistrarProducto] '{0}','{1}','{2}'", nombre, cantidad, precio);
            DataTable tblResult = Conexion.Consultar(Query);
            return tblResult;
        }
    }
}
