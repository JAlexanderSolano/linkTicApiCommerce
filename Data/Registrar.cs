using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Registrar
    {
        public DataTable Registrarme(string nombre, string identificacion, string telefono, string email, string usuario, string contrasena)
        {
            string Query = String.Format("EXEC [dbo].[sp_RegistrarUsuario] '{0}','{1}','{2}','{3}','{4}','{5}'", nombre, identificacion,telefono, email, usuario, contrasena);
            DataTable tblResult = Conexion.Consultar(Query);
            return tblResult;
        }
    }
}
