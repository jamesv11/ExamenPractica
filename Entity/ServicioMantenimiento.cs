using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ServicioMantenimiento
    {
        public string Codigo { get; set; }
        public string NombreServicio { get; set; }
        public decimal Valor { get; set; }
        public Contratista ContratistaServicio { get; set; }
        public DateTime FechaServicio { get; set; }

        public ServicioMantenimiento(Contratista contratista)
        {
            ContratistaServicio = new Contratista();
            ContratistaServicio.IdSurcusal = contratista.IdSurcusal;
            ContratistaServicio.Identificacion = contratista.Identificacion;
            ContratistaServicio.NombreContratista = contratista.NombreContratista;
        }

        public override string ToString()
        {
            return $"{ContratistaServicio.IdSurcusal};{ContratistaServicio.Identificacion};{ContratistaServicio.NombreContratista};" +
                $"{FechaServicio.ToString("DD/MM/YYYY")};{Codigo};{Valor}";
        }
    }
}
