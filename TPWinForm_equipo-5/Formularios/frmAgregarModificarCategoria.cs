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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
             Categoria categoria = new Categoria();
           
             Close();

        }
    }
}
