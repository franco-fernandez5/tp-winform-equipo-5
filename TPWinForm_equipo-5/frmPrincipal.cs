using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPWinForm_equipo_5.Formularios;

namespace TPWinForm_equipo_5
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void MenuMarcas_Click(object sender, EventArgs e)
        {
            FrmMarcas form = new FrmMarcas();
            form.ShowDialog();
        }

        private void menuCategorias_Click(object sender, EventArgs e)
        {
            FrmCategorias form = new FrmCategorias();
            form.ShowDialog();
        }

        private void menuArticulos_Click(object sender, EventArgs e)
        {
            FrmArticulos form = new FrmArticulos();
            form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
