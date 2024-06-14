using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class pedidos: Ipedidos
    {
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string producto { get; set; }
        public string fechaPedido { get; set; }
        public string precio { get; set; }

        public string total { get; set; }

        public int _state { get; set; }
        public pedidos() { }

        public pedidos(string nombre, string telefono, string email, string producto, string fechaPedido, string precio, string total, int state)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.email = email;
            this.producto = producto;
            this.fechaPedido = fechaPedido;
            this.precio = precio;
            this.total = total;
            this._state = state;
        }

        public List<pedidos> RetornarResultado(DataTable tbl)
        {
            List<pedidos> productos = new List<pedidos>();
            if (tbl.Rows.Count > 0)
            {
                string _nombre = "", _telefono = "", _email = "", _producto = "", _fechaPedido = "", _precio = "", _total = "";
                foreach (DataRow fila in tbl.Rows)
                {
                    _nombre = fila["nombre"].ToString();
                    _telefono = fila["telefono"].ToString();
                    _email = fila["email"].ToString();
                    _producto = fila["producto"].ToString();
                    _fechaPedido = fila["fechaPedido"].ToString();
                    _precio = fila["precio"].ToString();
                    _total = fila["total"].ToString();
                    productos.Add(new pedidos(_nombre, _telefono, _email, _producto, _fechaPedido, _precio,_total, 200) { });
                }

            }
            return productos;
        }
    }
}
