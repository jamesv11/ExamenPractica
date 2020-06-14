using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;

namespace Bll
{
    public class ServicioMantenimientoArcService
    {
        ServicioMantenimientoArcRepositorio arcRepositorio;

        public ServicioMantenimientoArcService()
        {
            arcRepositorio = new ServicioMantenimientoArcRepositorio();
        }
        public string Guardar(ServicioMantenimiento servicio)
        {
            try
            {               
                    arcRepositorio.Guardar(servicio);
                    return $"Se ha guardado correctamente ";
                }
                          
            catch (Exception e)
            {

                return $"Error en los datos {e.Message}";
            }


        }
        public RespuestaConsulta Consultar(string ruta)
        {
            
            RespuestaConsulta respuestaConsulta = new RespuestaConsulta();
            try
            {

                respuestaConsulta.Servicios = arcRepositorio.Consultar(ruta);
                foreach (var item in respuestaConsulta.Servicios)
                {
                    Console.WriteLine(item.ToString());
                }
                respuestaConsulta.Mensaje = "Consulta realizada con exito";
                return respuestaConsulta;
            }
            catch (Exception)
            {
                respuestaConsulta.Mensaje = "No hay mensaje que consultar";
                return respuestaConsulta;
            }
        }
    }
    public class RespuestaConsulta
    {
        public IList<ServicioMantenimiento> Servicios { get; set; }
        public string Mensaje { get; set; }
    }
}
