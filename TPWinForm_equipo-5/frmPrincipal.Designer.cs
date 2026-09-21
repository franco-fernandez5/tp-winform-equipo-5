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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGestion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuGestion
            // 
            this.menuGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMarcas,
            this.menuCategorias,
            this.menuArticulos});
            this.menuGestion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuGestion.Name = "menuGestion";
            this.menuGestion.Size = new System.Drawing.Size(107, 36);
            this.menuGestion.Text = "Gestion";
            // 
            // MenuMarcas
            // 
            this.MenuMarcas.Name = "MenuMarcas";
            this.MenuMarcas.Size = new System.Drawing.Size(200, 36);
            this.MenuMarcas.Text = "Marca";
            this.MenuMarcas.Click += new System.EventHandler(this.MenuMarcas_Click);
            // 
            // menuCategorias
            // 
            this.menuCategorias.Name = "menuCategorias";
            this.menuCategorias.Size = new System.Drawing.Size(200, 36);
            this.menuCategorias.Text = "Categorias";
            this.menuCategorias.Click += new System.EventHandler(this.menuCategorias_Click);
            // 
            // menuArticulos
            // 
            this.menuArticulos.Name = "menuArticulos";
            this.menuArticulos.Size = new System.Drawing.Size(200, 36);
            this.menuArticulos.Text = "Articulos";
            this.menuArticulos.Click += new System.EventHandler(this.menuArticulos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(205, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA DE CATALOGOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(36, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(620, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Utilizar el menu \"Gestion\" para administrar Marcas, Categorias y Articulos.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "↑";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Catalogos";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

