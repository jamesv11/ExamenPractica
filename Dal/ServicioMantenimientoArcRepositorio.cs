using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace Dal
{
    public class ServicioMantenimientoArcRepositorio
    {


        private string rutaGuardar = @"log.txt";
        private IList<ServicioMantenimiento> ServicioMantenimientos = new List<ServicioMantenimiento>();

        public void Guardar(ServicioMantenimiento servicio)
        {
            FileStream fileStream = new FileStream(rutaGuardar, FileMode.Append);
            StreamWriter escritor = new StreamWriter(fileStream);
            escritor.WriteLine(servicio.ToString());

            escritor.Close();
            fileStream.Close();

        }

        //    public IList<ServicioMantenimiento> Consultar(string ruta)
        //    {
        //        ServicioMantenimientos.Clear();

        //        string linea = string.Empty;
        //        FileStream fileStream = new FileStream(path: ruta, FileMode.Open);
        //        StreamReader lector = new StreamReader(fileStream);

        //            while ((linea = lector.ReadLine()) != null)
        //        {

        //            String[] datos = linea.Split(';');
        //            ServicioMantenimiento servicioMantenimiento = new ServicioMantenimiento();
        //            servicioMantenimiento.Contratista.IdSurcusal = datos[0];
        //            servicioMantenimiento.Contratista.Identificacion = datos[1];
        //            servicioMantenimiento.Contratista.NombreContratista = datos[2];
        //            servicioMantenimiento.FechaServicio = Convert.ToDateTime(datos[3]);
        //            servicioMantenimiento.Codigo = datos[4];
        //            servicioMantenimiento.Valor = Convert.ToDecimal(datos[5]);
        //            ServicioMantenimientos.Add(servicioMantenimiento);
        //        }

        //        lector.Close();
        //        fileStream.Close();
        //        return ServicioMantenimientos;
        //    }
        //}
    }
}
