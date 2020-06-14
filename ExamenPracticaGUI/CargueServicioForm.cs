using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using Entity;

namespace ExamenPracticaGUI
{
    public partial class CargueServicioForm : Form
    {
        IList<ServicioMantenimiento> servicioMantenimientos = new List<ServicioMantenimiento>();
        ServicioMantenimientoArcService ServicioArchivo;
        ServicioMantenimientoDbService ServicioDb;
        public CargueServicioForm()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            ServicioArchivo = new ServicioMantenimientoArcService();
            ServicioDb = new ServicioMantenimientoDbService(connectionString);
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CargarBtn_Click(object sender, EventArgs e)
        {
            servicioMantenimientos.Clear();
            string linea = string.Empty;
            RespuestaConsulta respuesta = new RespuestaConsulta();
            var fileContent = string.Empty;
            var filepath = string.Empty;
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = "C:\\";
                fileDialog.Filter = "txt files(*.txt)|*.txt|All files (*.*)|*.*";
                fileDialog.FilterIndex = 2;
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = fileDialog.FileName;
                    var fileStream = fileDialog.OpenFile();

                    using (StreamReader lector = new StreamReader(fileStream))
                    {

                        //fileContent = lector.ReadToEnd();
                        while ((linea = lector.ReadLine()) != null)
                        {

                            String[] datos = linea.Split(';');
                            Contratista contratista = new Contratista();
                            contratista.IdSurcusal = datos[0];
                            contratista.Identificacion = datos[1];
                            contratista.NombreContratista = datos[2];
                            ServicioMantenimiento servicioMantenimiento = new ServicioMantenimiento(contratista);                
                            
                            servicioMantenimiento.FechaServicio = Convert.ToDateTime(datos[3]);
                            servicioMantenimiento.Codigo = datos[4];
                            servicioMantenimiento.Valor = Convert.ToDecimal(datos[5]);
                            servicioMantenimientos.Add(servicioMantenimiento);
                        }

                        lector.Close();

                    }

                    foreach (var item in servicioMantenimientos)
                    {
                        ServicioDb.Guardar(item);
                    }
                    
                }

               
            }
                 
        //respuesta = servicio.Consultar();
            MessageBox.Show(fileContent, "Mensaje de Guardado" + filepath, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        
        }
        public void Validaciones()
        {
            foreach (var item in servicioMantenimientos)
            {
              
            }

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
