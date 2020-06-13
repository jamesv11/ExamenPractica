using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Reporte
    {
        public Sucursal Sucursal { get; set; }
        public ServicioMantenimiento Servicio { get; set; }
        public Contratista Contratista { get; set; }
        public DateTime Fecha { get; set; }
     
    }
}
