using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class producto: Iproducto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string cantidad { get; set; }
        public string precio { get; set; }

        public int _estado { get; set; }
        public producto() { }

        public producto(int id, string name, string cantidad, string precio, int estado)
        {
            this.id = id;
            this.name = name;
            this.cantidad = cantidad;
            this.precio = precio;
            this._estado = estado;
        }

        public List<producto> RetornarResultado(DataTable tbl)
        {
            List<producto> productos = new List<producto>();
            if (tbl.Rows.Count > 0)
            {
                string _id = "", _nombre = "", _cantidad = "", _precio = "";
                foreach (DataRow fila in tbl.Rows)
                {
                    _id = fila["id"].ToString();
                    _nombre = fila["nombre"].ToString();
                    _cantidad = fila["cantidad"].ToString();
                    _precio = fila["precio"].ToString();
                    productos.Add(new producto(Int32.Parse(_id), _nombre, _cantidad, _precio, 200) { });
                }
               
            }
            return productos;
        }
    }
}
