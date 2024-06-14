using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Data;

namespace Interface
{
    public interface Iresultado
    {
       List<Entities.resultado> RetornarResultado(DataTable tbl);
    }
}
