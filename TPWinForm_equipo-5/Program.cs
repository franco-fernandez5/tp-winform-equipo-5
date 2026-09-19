using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPWinForm_equipo_5.Formularios;

namespace TPWinForm_equipo_5
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Formularios.frmAgregarModificarCategoria());
            //Application.Run(new Formularios.FrmArticulos());
            //Application.Run(new Formularios.FrmMarcas());
            //Application.Run(new FrmCategorias());
            Application.Run(new frmPrincipal());
        }
    }
}
