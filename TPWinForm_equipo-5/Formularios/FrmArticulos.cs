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
    public partial class FrmArticulos : Form
    {
        private List<Articulo> listaArticulos;

        public FrmArticulos()
        {
            InitializeComponent();
        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem; //sin la BD conectada el modificar va a lanzar error
            FrmAgregarArticulo modificar = new FrmAgregarArticulo(seleccionado);
            modificar.ShowDialog();
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

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;

                dgvArticulos.Columns["Id"].Visible = false;
                dgvArticulos.Columns["Marca"].Visible = false;
                dgvArticulos.Columns["Categoria"].Visible = false;

                if (listaArticulos.Count > 0 &&
                    listaArticulos[0].Imagenes != null &&
                    listaArticulos[0].Imagenes.Count > 0)
                {
                    CargarImagen(listaArticulos[0].Imagenes[0].ImagenUrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                if (seleccionado.Imagenes != null && seleccionado.Imagenes.Count > 0)
                {
                    CargarImagen(seleccionado.Imagenes[0].ImagenUrl);
                }
            }
        }

    }
}
