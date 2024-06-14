using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Data;

namespace Interface
{
    public interface Iresultado
    {
        List<resultado> RetornarResultado(DataTable tbl);
    }
}
