namespace TPWinForm_equipo_5
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGestion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuGestion
            // 
            this.menuGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMarcas,
            this.menuCategorias,
            this.menuArticulos});
            this.menuGestion.Name = "menuGestion";
            this.menuGestion.Size = new System.Drawing.Size(59, 20);
            this.menuGestion.Text = "Gestion";
            // 
            // MenuMarcas
            // 
            this.MenuMarcas.Name = "MenuMarcas";
            this.MenuMarcas.Size = new System.Drawing.Size(180, 22);
            this.MenuMarcas.Text = "Marca";
            this.MenuMarcas.Click += new System.EventHandler(this.MenuMarcas_Click);
            // 
            // menuCategorias
            // 
            this.menuCategorias.Name = "menuCategorias";
            this.menuCategorias.Size = new System.Drawing.Size(180, 22);
            this.menuCategorias.Text = "Categorias";
            this.menuCategorias.Click += new System.EventHandler(this.menuCategorias_Click);
            // 
            // menuArticulos
            // 
            this.menuArticulos.Name = "menuArticulos";
            this.menuArticulos.Size = new System.Drawing.Size(180, 22);
            this.menuArticulos.Text = "Articulos";
            this.menuArticulos.Click += new System.EventHandler(this.menuArticulos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuGestion;
        private System.Windows.Forms.ToolStripMenuItem MenuMarcas;
        private System.Windows.Forms.ToolStripMenuItem menuCategorias;
        private System.Windows.Forms.ToolStripMenuItem menuArticulos;
    }
}

