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

namespace TPWinForm_equipo_5.Formularios
{
    public partial class FrmDetalleArticulo : Form
    {
        private Articulo articulo;

        public FrmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void cargarDatos()
        {
            lblIdArticulo.Text = articulo.Id.ToString();
            lblCodigo.Text = articulo.Codigo;
            lblNombre.Text = articulo.Nombre;
            lblDescripcion.Text = articulo.Descripcion;
            lblMarca.Text = articulo.Marca.Descripcion;
            lblIdMarca.Text = articulo.Marca.Id.ToString();
            lblCategoria.Text = articulo.Categoria.Descripcion;
            lblIdCategoria.Text = articulo.Categoria.Id.ToString();
            lblPrecio.Text = articulo.Precio.ToString();

            lbxImagenes.Items.Clear();

            foreach (var imagen in articulo.Imagenes)
            {
                lbxImagenes.Items.Add(imagen.ImagenUrl);
            }
        }

        private void FrmDetalleArticulo_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void lbxImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxImagenes.SelectedItem != null)
            {
                string imagen = lbxImagenes.SelectedItem.ToString();

                try
                {
                    pbxImagen.Load(imagen);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
