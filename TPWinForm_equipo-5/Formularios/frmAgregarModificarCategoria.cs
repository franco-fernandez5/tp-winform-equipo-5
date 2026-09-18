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
    public partial class frmAgregarModificarCategoria : Form
    {
        private Categoria categoria = null; 
        public frmAgregarModificarCategoria()
        {

            InitializeComponent();

        }

        public frmAgregarModificarCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoria";
        }

        private void frmAgregarModificarCategoria_Load(object sender, EventArgs e)
        {
            if (categoria != null)
            {
                txtDescripcionCategoria.Text = categoria.Descripcion;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                if (categoria == null)
                {
                    categoria = new Categoria();
                    categoria.Descripcion = txtDescripcionCategoria.Text;
                    negocio.agregar(categoria);
                    MessageBox.Show("Categoria agregada ");
                }
                else
                {
                    categoria.Descripcion = txtDescripcionCategoria.Text;
                    negocio.modificar(categoria);
                    MessageBox.Show("Categoria modificada ");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }

        
    
}
