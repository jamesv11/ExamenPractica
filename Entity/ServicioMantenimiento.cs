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
        public Contratista Contratista { get; set; }
        public DateTime FechaServicio { get; set; }


        public override string ToString()
        {
            return $"{Contratista.IdSurcusal};{Contratista.Identificacion};{Contratista.NombreContratista};" +
                $"{FechaServicio.ToString("DD/MM/YYYY")};{Codigo};{Valor}";
        }
    }
}
