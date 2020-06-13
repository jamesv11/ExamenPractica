using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Sucursal
    {
        public string Codigo { get; set; }
        public string NombreSurcusal { get; set; }
        IList<Contratista> Contratistas { get; set; }

    }
}
