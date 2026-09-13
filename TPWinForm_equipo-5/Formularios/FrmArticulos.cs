using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_5.Formularios
{
    public partial class FrmArticulos : Form
    {
        public FrmArticulos()
        {
            InitializeComponent();
        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {

        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            // Realizar eliminación física del artículo seleccionado

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBox.Show("¿Está seguro de que desea eliminar el artículo seleccionado?", "Confirmar eliminación", buttons);
        }

        private void btnDetalleArticulo_Click(object sender, EventArgs e)
        {

        }

        private void agregarNuevoArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarArticulo ventana = new FrmAgregarArticulo();
            ventana.ShowDialog();
        }

        //private void CargarImagen(string imagen)
        //{
        //    try
        //    {
        //        pbxArticulo.Load(imagen);
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
    }
}
