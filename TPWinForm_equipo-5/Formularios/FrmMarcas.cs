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
        private List<Marca> listaMarcas;
        public FrmMarcas()
        {
            InitializeComponent();
            MarcaNegocio negocio = new MarcaNegocio();
            listaMarcas = negocio.listar();
            dgvMarcas.DataSource = listaMarcas;
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            FrmAgregarModificarMarca formulario = new FrmAgregarModificarMarca();
            formulario.ShowDialog();
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            if(dgvMarcas.CurrentRow  == null)
            {
                MessageBox.Show("Seleccione una marca para modificarla.");
                return;
            }

            Marca marcaSeleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

            FrmAgregarModificarMarca formulario = new FrmAgregarModificarMarca(marcaSeleccionada);

            formulario.ShowDialog();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una marca para eliminarla.");
                return;
            }

            Marca marcaSeleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("Estas seguro de eleminar esta marca?", "Eliminar Marca");

            if(respuesta == DialogResult.Yes)
            {
                //Para cuando empezemos con la base de datos aplicamos baja fisica.
            }
        }
    }
}
