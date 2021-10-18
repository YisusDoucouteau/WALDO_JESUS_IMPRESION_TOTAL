
namespace WALDO_JESUS_IMPRESION_TOTAL
{
    partial class frmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuImprenta = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.menTipoProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.menCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menOrdenTrabajo = new System.Windows.Forms.ToolStripMenuItem();
            this.menDetalleOrdenTrabajo = new System.Windows.Forms.ToolStripMenuItem();
            this.menDescuentos = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.descuentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImprenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "UNIVERSE PRINT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuImprenta
            // 
            this.menuImprenta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuImprenta.Location = new System.Drawing.Point(0, 0);
            this.menuImprenta.Name = "menuImprenta";
            this.menuImprenta.Size = new System.Drawing.Size(789, 24);
            this.menuImprenta.TabIndex = 1;
            this.menuImprenta.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menProducto,
            this.menCliente,
            this.menOrdenTrabajo,
            this.menDescuentos});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // menProducto
            // 
            this.menProducto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menTipoProducto});
            this.menProducto.Name = "menProducto";
            this.menProducto.Size = new System.Drawing.Size(180, 22);
            this.menProducto.Text = "Producto";
            this.menProducto.Click += new System.EventHandler(this.menProducto_Click);
            // 
            // menTipoProducto
            // 
            this.menTipoProducto.Name = "menTipoProducto";
            this.menTipoProducto.Size = new System.Drawing.Size(150, 22);
            this.menTipoProducto.Text = "Tipo Producto";
            // 
            // menCliente
            // 
            this.menCliente.Name = "menCliente";
            this.menCliente.Size = new System.Drawing.Size(180, 22);
            this.menCliente.Text = "Cliente";
            this.menCliente.Click += new System.EventHandler(this.menCliente_Click);
            // 
            // menOrdenTrabajo
            // 
            this.menOrdenTrabajo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menDetalleOrdenTrabajo});
            this.menOrdenTrabajo.Name = "menOrdenTrabajo";
            this.menOrdenTrabajo.Size = new System.Drawing.Size(180, 22);
            this.menOrdenTrabajo.Text = "Orden Trabajo";
            this.menOrdenTrabajo.Click += new System.EventHandler(this.menOrdenTrabajo_Click);
            // 
            // menDetalleOrdenTrabajo
            // 
            this.menDetalleOrdenTrabajo.Name = "menDetalleOrdenTrabajo";
            this.menDetalleOrdenTrabajo.Size = new System.Drawing.Size(188, 22);
            this.menDetalleOrdenTrabajo.Text = "Detalle Orden Trabajo";
            // 
            // menDescuentos
            // 
            this.menDescuentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descuentoToolStripMenuItem});
            this.menDescuentos.Name = "menDescuentos";
            this.menDescuentos.Size = new System.Drawing.Size(180, 22);
            this.menDescuentos.Text = "Descuentos";
            this.menDescuentos.Click += new System.EventHandler(this.menDescuentos_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menAyuda});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // menAyuda
            // 
            this.menAyuda.Name = "menAyuda";
            this.menAyuda.Size = new System.Drawing.Size(135, 22);
            this.menAyuda.Text = "Acerca de...";
            // 
            // descuentoToolStripMenuItem
            // 
            this.descuentoToolStripMenuItem.Name = "descuentoToolStripMenuItem";
            this.descuentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.descuentoToolStripMenuItem.Text = "Descuento";
            this.descuentoToolStripMenuItem.Click += new System.EventHandler(this.descuentoToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuImprenta);
            this.MainMenuStrip = this.menuImprenta;
            this.Name = "frmMenu";
            this.Text = "UNIVERSE PRINT";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuImprenta.ResumeLayout(false);
            this.menuImprenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuImprenta;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menAyuda;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menProducto;
        private System.Windows.Forms.ToolStripMenuItem menTipoProducto;
        private System.Windows.Forms.ToolStripMenuItem menCliente;
        private System.Windows.Forms.ToolStripMenuItem menOrdenTrabajo;
        private System.Windows.Forms.ToolStripMenuItem menDetalleOrdenTrabajo;
        private System.Windows.Forms.ToolStripMenuItem menDescuentos;
        private System.Windows.Forms.ToolStripMenuItem descuentoToolStripMenuItem;
    }
}

