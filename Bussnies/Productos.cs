using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussnies
{
    public class Productos
    {
        public DataTable listarProductos()
        {
            Data.Productos productos = new Data.Productos();
            DataTable tblResult = productos.listarProductos();
            return tblResult;
        }

        public DataTable RegistrarProductos(string nombre, string cantidad, string precio)
        {
            
            Data.Productos productos = new Data.Productos();
            DataTable tblResult = productos.RegistrarProductos(nombre, cantidad, precio);
            return tblResult;
        }
    }
}
