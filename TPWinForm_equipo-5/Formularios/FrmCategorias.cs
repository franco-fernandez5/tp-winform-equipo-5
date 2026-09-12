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
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            frmAgregarModificarCategoria form = new frmAgregarModificarCategoria();   
            form.ShowDialog();
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            Categoria seleccionada = (Categoria)dvgCategorias.CurrentRow.DataBoundItem;
            frmAgregarModificarCategoria form = new frmAgregarModificarCategoria(seleccionada);   
            form.ShowDialog();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {

        }

       
    }
}
