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
    public partial class FrmAgregarArticulo : Form
    {
        private Articulo articulo = null;

        public FrmAgregarArticulo()
        {
            InitializeComponent();
        }

        public FrmAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if(articulo == null)
                    articulo = new Articulo();
                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    MessageBox.Show("El código no puede estar vacío");
                    return;
                }
                articulo.Codigo = txtCodigo.Text;

                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("El nombre no puede estar vacío");
                    return;
                }
                articulo.Nombre = txtNombre.Text;

                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("La descripción no puede estar vacía");
                    return;
                }
                articulo.Descripcion = txtDescripcion.Text;

                if (string.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("El precio no puede estar vacío");
                    return;
                }
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (cbxMarca.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una Marca");
                    return;
                }
                articulo.Marca = (Marca)cbxMarca.SelectedItem;

                if (cbxCategoria.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una Categoría");
                    return;
                }
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;

                articulo.Imagenes = new List<Imagen>();

                foreach (var item in lbxImagenes.Items)
                {
                    Imagen imagen = new Imagen();
                    imagen.ImagenUrl = item.ToString();
                    articulo.Imagenes.Add(imagen);
                }

                if (articulo.Id != 0)
                    negocio.modificar(articulo);
                else
                    negocio.agregar(articulo);

                MessageBox.Show("Articulo guardado exitosamente.");

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string imagen = txtImagen.Text;

            if(imagen != "")
            {
                lbxImagenes.Items.Add(imagen);
                txtImagen.Clear();
            }
        }

        private void FrmAgregarArticulo_Load(object sender, EventArgs e)
        {
            try
            {

                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";

                MarcaNegocio negocioMarca = new MarcaNegocio();
                CategoriaNegocio negocioCategoria = new CategoriaNegocio();

                cbxMarca.DataSource = negocioMarca.listar();
                cbxCategoria.DataSource = negocioCategoria.listar();

                if (articulo == null)
                {
                    cbxMarca.SelectedIndex = -1;
                    cbxCategoria.SelectedIndex = -1;
                }
                else
                {

                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();

                    lbxImagenes.Items.Clear();

                    foreach (var imagen in articulo.Imagenes)
                    {
                        lbxImagenes.Items.Add(imagen.ImagenUrl);
                    }
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                    cbxMarca.SelectedValue = articulo.Marca.Id;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            if(lbxImagenes.SelectedItem != null)
            {
                lbxImagenes.Items.Remove(lbxImagenes.SelectedItem);
            }
        }
    }
}
