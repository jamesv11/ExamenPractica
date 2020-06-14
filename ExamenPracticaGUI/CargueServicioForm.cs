using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        ServicioMantenimientoArcService servicio;
        public CargueServicioForm()
        {
            servicio = new ServicioMantenimientoArcService();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CargarBtn_Click(object sender, EventArgs e)
        {
            RespuestaConsulta respuesta = new RespuestaConsulta();
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            string ruta = fileDialog.FileName;//Obtener la ruta
            respuesta = servicio.Consultar(ruta);
            MessageBox.Show(respuesta.Mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
