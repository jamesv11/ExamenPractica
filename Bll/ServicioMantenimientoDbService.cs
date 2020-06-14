using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;

namespace Bll
{
    public class ServicioMantenimientoDbService
    {
        private ServicioMantenimientoDbRepositorio dbRepositorio;
        private readonly ConnectionManager conexion;

        public ServicioMantenimientoDbService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            dbRepositorio = new ServicioMantenimientoDbRepositorio(conexion);

        }
        public string Guardar(ServicioMantenimiento servicio)
        {

            {
                try
                {
                  
                    conexion.Open();
                    dbRepositorio.Guardar(servicio);
                    conexion.Close();
                    return $"Se guardaron los datos satisfactoriamente";
                }
                catch (Exception e)
                {
                    return $"Error de la Aplicacion: {e.Message}";
                }
                finally { conexion.Close(); }
            }
        }
    }
}
