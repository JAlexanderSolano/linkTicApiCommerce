using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussnies
{
    public class Registrar
    {
        public DataTable Registrarme(string nombre, string identificacion, string telefono, string email,string usuario, string contrasena)
        {
            Data.Registrar registrar = new Data.Registrar();
            DataTable tblResult = registrar.Registrarme(nombre, identificacion, telefono, email, usuario, contrasena);
            return tblResult;
        }
    }
}
