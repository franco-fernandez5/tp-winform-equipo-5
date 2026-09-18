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
    public partial class FrmCategorias : Form
    {

        private List<Categoria> listaCategorias;
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            cargar();
        }


        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                listaCategorias = negocio.listar();
                dgvCategorias.DataSource = listaCategorias;
                dgvCategorias.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }





        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            frmAgregarModificarCategoria form = new frmAgregarModificarCategoria();   
            form.ShowDialog();
            cargar();
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            if(dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una categoria para modificar");
                return;
            }

            Categoria seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            frmAgregarModificarCategoria form = new frmAgregarModificarCategoria(seleccionada);   
            form.ShowDialog();
            cargar();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una categoria para eliminar");
                return;
            }
            
            Categoria seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show(
                "¿Seguro que desea eliminar la categoría '" + seleccionada.Descripcion + "'?",
                     "Confirmar eliminacion",
                    MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    CategoriaNegocio negocio = new CategoriaNegocio();
                    negocio.eliminar(seleccionada.Id);
                    MessageBox.Show("Categoria eliminada");
                    cargar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

        }

       
    }
}
