
namespace WALDO_JESUS_IMPRESION_TOTAL
{
    partial class frmProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoProducto = new System.Windows.Forms.ComboBox();
            this.btnTipoProducto = new System.Windows.Forms.Button();
            this.lblNombreTipoProducto = new System.Windows.Forms.Label();
            this.txtNombreTipoProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarTipoProducto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPrecioProducto = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstadoProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Producto:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(54, 96);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(243, 20);
            this.txtNombreProducto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo Producto:";
            // 
            // cboTipoProducto
            // 
            this.cboTipoProducto.FormattingEnabled = true;
            this.cboTipoProducto.Location = new System.Drawing.Point(348, 95);
            this.cboTipoProducto.Name = "cboTipoProducto";
            this.cboTipoProducto.Size = new System.Drawing.Size(214, 21);
            this.cboTipoProducto.TabIndex = 5;
            this.cboTipoProducto.SelectedIndexChanged += new System.EventHandler(this.cboTipoProducto_SelectedIndexChanged);
            // 
            // btnTipoProducto
            // 
            this.btnTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoProducto.Location = new System.Drawing.Point(568, 93);
            this.btnTipoProducto.Name = "btnTipoProducto";
            this.btnTipoProducto.Size = new System.Drawing.Size(46, 23);
            this.btnTipoProducto.TabIndex = 6;
            this.btnTipoProducto.Text = "...";
            this.btnTipoProducto.UseVisualStyleBackColor = true;
            this.btnTipoProducto.Click += new System.EventHandler(this.btnTipoProducto_Click);
            // 
            // lblNombreTipoProducto
            // 
            this.lblNombreTipoProducto.AutoSize = true;
            this.lblNombreTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTipoProducto.Location = new System.Drawing.Point(345, 119);
            this.lblNombreTipoProducto.Name = "lblNombreTipoProducto";
            this.lblNombreTipoProducto.Size = new System.Drawing.Size(176, 17);
            this.lblNombreTipoProducto.TabIndex = 7;
            this.lblNombreTipoProducto.Text = "Nombre Tipo Producto:";
            this.lblNombreTipoProducto.Visible = false;
            // 
            // txtNombreTipoProducto
            // 
            this.txtNombreTipoProducto.Location = new System.Drawing.Point(348, 151);
            this.txtNombreTipoProducto.Name = "txtNombreTipoProducto";
            this.txtNombreTipoProducto.Size = new System.Drawing.Size(218, 20);
            this.txtNombreTipoProducto.TabIndex = 8;
            this.txtNombreTipoProducto.Visible = false;
            // 
            // btnAgregarTipoProducto
            // 
            this.btnAgregarTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTipoProducto.Location = new System.Drawing.Point(593, 142);
            this.btnAgregarTipoProducto.Name = "btnAgregarTipoProducto";
            this.btnAgregarTipoProducto.Size = new System.Drawing.Size(111, 29);
            this.btnAgregarTipoProducto.TabIndex = 9;
            this.btnAgregarTipoProducto.Text = "Agregar";
            this.btnAgregarTipoProducto.UseVisualStyleBackColor = true;
            this.btnAgregarTipoProducto.Visible = false;
            this.btnAgregarTipoProducto.Click += new System.EventHandler(this.btnAgregarTipoProducto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precio Producto:";
            // 
            // nudPrecioProducto
            // 
            this.nudPrecioProducto.Location = new System.Drawing.Point(54, 152);
            this.nudPrecioProducto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrecioProducto.Name = "nudPrecioProducto";
            this.nudPrecioProducto.Size = new System.Drawing.Size(120, 20);
            this.nudPrecioProducto.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Estado Producto:";
            // 
            // txtEstadoProducto
            // 
            this.txtEstadoProducto.Location = new System.Drawing.Point(54, 211);
            this.txtEstadoProducto.Multiline = true;
            this.txtEstadoProducto.Name = "txtEstadoProducto";
            this.txtEstadoProducto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEstadoProducto.Size = new System.Drawing.Size(243, 66);
            this.txtEstadoProducto.TabIndex = 13;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Location = new System.Drawing.Point(349, 228);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(190, 37);
            this.btnAgregarProducto.TabIndex = 14;
            this.btnAgregarProducto.Text = "Registrar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(54, 288);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.Size = new System.Drawing.Size(626, 150);
            this.dgvProducto.TabIndex = 15;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.txtEstadoProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudPrecioProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregarTipoProducto);
            this.Controls.Add(this.txtNombreTipoProducto);
            this.Controls.Add(this.lblNombreTipoProducto);
            this.Controls.Add(this.btnTipoProducto);
            this.Controls.Add(this.cboTipoProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTipoProducto;
        private System.Windows.Forms.Button btnTipoProducto;
        private System.Windows.Forms.Label lblNombreTipoProducto;
        private System.Windows.Forms.TextBox txtNombreTipoProducto;
        private System.Windows.Forms.Button btnAgregarTipoProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPrecioProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEstadoProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridView dgvProducto;
    }
}