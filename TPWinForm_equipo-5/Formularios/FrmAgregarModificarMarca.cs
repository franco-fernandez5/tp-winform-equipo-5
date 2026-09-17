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
    public partial class FrmAgregarModificarMarca : Form
    {
        private Marca marca = null;
        public FrmAgregarModificarMarca()
        {
            InitializeComponent();
        }
        public FrmAgregarModificarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            txtDescripcionMarca.Text = marca.Descripcion;
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();

                if (marca == null)
                {
                    Marca marca = new Marca();
                    marca.Descripcion = txtDescripcionMarca.Text;
                    marcaNegocio.agregarMarca(marca);
                    MessageBox.Show("Marca agregada");
                }
                else
                {
                    marca.Descripcion = txtDescripcionMarca.Text;
                    marcaNegocio.modificarMarca(marca);
                    MessageBox.Show("Marca modificada");
                }
                
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
