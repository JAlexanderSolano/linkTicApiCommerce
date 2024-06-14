using Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class resultado: Iresultado
    {
        public string _resultado { get; set; }
        public int _state { get; set; }
        public resultado() { }
        public resultado(string _resultado, int state)
        {
            this._resultado = _resultado;
            this._state = state;
        }

        public List<resultado> RetornarResultado(DataTable tbl)
        {
            List<resultado> resultados = new List<resultado>();
            if (tbl.Rows.Count > 0)
            {
                string _res = "";
                foreach (DataRow fila in tbl.Rows)
                {
                    _res = fila["resultado"].ToString();
                }
                resultados.Add(new resultado(_res, 200) { });
            }
            return resultados;
        }

    }

}
