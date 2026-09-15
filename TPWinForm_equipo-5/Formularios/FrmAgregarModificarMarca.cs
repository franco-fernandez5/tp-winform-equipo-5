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
            Text = "Modificar Marca";
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (marca == null)
                    marca = new Marca();
                marca.Descripcion = txtDescripcionMarca.Text;
                MessageBox.Show("Marca agregada");

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
