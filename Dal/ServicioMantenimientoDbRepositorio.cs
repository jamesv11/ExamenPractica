using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    class ServicioMantenimientoDbRepositorio
    {
        private readonly SqlConnection _connection;
        IList<ServicioMantenimiento> servicioMantenimientos = new List<ServicioMantenimiento>();       
        public ServicioMantenimientoDbRepositorio(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public void Guardar(ServicioMantenimiento servicio)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "INSERTAR_LIQUIDACION";
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@SEDE", servicio.Contratista.IdSurcusal);
                command.Parameters.AddWithValue("@IDENTIFACION", servicio.Contratista.Identificacion);
                command.Parameters.AddWithValue("@NOMBRE", servicio.Contratista.NombreContratista);
                command.Parameters.AddWithValue("@FECHA", servicio.FechaServicio);
                command.Parameters.AddWithValue("@VALOR", servicio.Valor);
                var filas = command.ExecuteNonQuery();

            }
        }

        public IList<ServicioMantenimiento> Consultar()
        {
            SqlDataReader dataReader;
            List<ServicioMantenimiento> personas = new List<ServicioMantenimiento>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select Sede,Identificacion, Nombre,year(fecha)as Vigencia, month(fecha) as Mes, sum(valor) as Liquidacion from baseliquidacion group by Identificacion, Nombre, year(fecha), month(fecha),SEDE";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        if (!dataReader.HasRows) return null;
                        ServicioMantenimiento servicio = new ServicioMantenimiento();
                        servicio.Contratista.IdSurcusal = dataReader.GetString(0);
                      

                  
                    }
                }
            }
            return personas;


        }

    }
}
