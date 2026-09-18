using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPWinForm_equipo_5.Dominio;
using TPWinForm_equipo_5.Negocio;

namespace TPWinForm_equipo_5.Formularios
{
    public partial class FrmMarcas : Form
    {
        public FrmMarcas()
        {
            InitializeComponent();
        }
        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            cargarMarcas();
        }
        private void cargarMarcas()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            dgvMarcas.DataSource = negocio.listar();
        }
        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            FrmAgregarModificarMarca formulario = new FrmAgregarModificarMarca();
            formulario.ShowDialog();
            cargarMarcas();
        }
        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            if(dgvMarcas.CurrentRow  == null)
            {
                MessageBox.Show("Seleccione una marca para modificarla.");
                return;
            }
            else
            {
                Marca marcaSeleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                FrmAgregarModificarMarca formulario = new FrmAgregarModificarMarca(marcaSeleccionada);
                formulario.ShowDialog();
                cargarMarcas();
            }
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una marca para eliminarla.");
                return;
            }

            Marca marcaSeleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("Estas seguro de eleminar esta marca?", "Eliminar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(respuesta == DialogResult.Yes)
            {
                try
                {
                    MarcaNegocio negocio = new MarcaNegocio();
                    negocio.eliminarMarca(marcaSeleccionada.Id);

                    MessageBox.Show("Marca eliminada correctamente.");

                    cargarMarcas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
