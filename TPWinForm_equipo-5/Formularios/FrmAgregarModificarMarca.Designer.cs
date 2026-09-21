namespace TPWinForm_equipo_5.Formularios
{
    partial class FrmAgregarModificarMarca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDescripcionMarca = new System.Windows.Forms.Label();
            this.txtDescripcionMarca = new System.Windows.Forms.TextBox();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescripcionMarca
            // 
            this.lblDescripcionMarca.AutoSize = true;
            this.lblDescripcionMarca.Location = new System.Drawing.Point(101, 93);
            this.lblDescripcionMarca.Name = "lblDescripcionMarca";
            this.lblDescripcionMarca.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionMarca.TabIndex = 0;
            this.lblDescripcionMarca.Text = "Descripcion:";
            // 
            // txtDescripcionMarca
            // 
            this.txtDescripcionMarca.Location = new System.Drawing.Point(104, 109);
            this.txtDescripcionMarca.MaxLength = 50;
            this.txtDescripcionMarca.Name = "txtDescripcionMarca";
            this.txtDescripcionMarca.Size = new System.Drawing.Size(184, 20);
            this.txtDescripcionMarca.TabIndex = 1;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(104, 183);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(112, 61);
            this.btnAgregarMarca.TabIndex = 2;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.Location = new System.Drawing.Point(246, 184);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(112, 60);
            this.btnCancelarMarca.TabIndex = 3;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = true;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // FrmAgregarModificarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.txtDescripcionMarca);
            this.Controls.Add(this.lblDescripcionMarca);
            this.Name = "FrmAgregarModificarMarca";
            this.Text = "Agregar/Modificar Marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcionMarca;
        private System.Windows.Forms.TextBox txtDescripcionMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
    }
}