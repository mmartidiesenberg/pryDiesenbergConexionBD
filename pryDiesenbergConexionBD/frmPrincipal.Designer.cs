namespace pryDiesenbergConexionBD
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
            this.lblEstadoConexion = new System.Windows.Forms.StatusStrip();
            this.lblEstadoConexion1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblEstadoConexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstadoConexion
            // 
            this.lblEstadoConexion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoConexion1});
            this.lblEstadoConexion.Location = new System.Drawing.Point(0, 428);
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Size = new System.Drawing.Size(800, 22);
            this.lblEstadoConexion.TabIndex = 0;
            this.lblEstadoConexion.Text = "statusStrip1";
            // 
            // lblEstadoConexion1
            // 
            this.lblEstadoConexion1.Name = "lblEstadoConexion1";
            this.lblEstadoConexion1.Size = new System.Drawing.Size(118, 17);
            this.lblEstadoConexion1.Text = "toolStripStatusLabel1";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(120, 53);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(427, 289);
            this.dgvDatos.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblEstadoConexion);
            this.Name = "frmPrincipal";
            this.Text = "Conexión Base de Datos en Access";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.lblEstadoConexion.ResumeLayout(false);
            this.lblEstadoConexion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip lblEstadoConexion;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoConexion1;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}

