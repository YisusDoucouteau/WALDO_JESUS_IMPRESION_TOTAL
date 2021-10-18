using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WALDO_JESUS_IMPRESION_TOTAL
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }
        //agregando la base de datos
        DSimprenta ds = new DSimprenta();
        DSimprentaTableAdapters.tipoProductoTableAdapter tTipoProducto = new DSimprentaTableAdapters.tipoProductoTableAdapter();
        DSimprentaTableAdapters.productoTableAdapter tProducto = new DSimprentaTableAdapters.productoTableAdapter();


        private void btnTipoProducto_Click(object sender, EventArgs e)
        {
            lblNombreTipoProducto.Visible = true;
            txtNombreTipoProducto.Visible = true;
            btnAgregarTipoProducto.Visible = true;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            tProducto.Fill(ds.producto);
            tTipoProducto.Fill(ds.tipoProducto);

            cboTipoProducto.DataSource = ds.tipoProducto;
            cboTipoProducto.DisplayMember = "nombreTipoProducto";
            cboTipoProducto.ValueMember = "idTipoProducto";

            dgvProducto.DataSource = ds.producto;

        }

        private void btnAgregarTipoProducto_Click(object sender, EventArgs e)
        {
            int idTipoProducto = Convert.ToInt32(ds.tipoProducto.Rows[ds.tipoProducto.Rows.Count - 1].ItemArray[0]);
            tTipoProducto.Insert( idTipoProducto+1, txtNombreTipoProducto.Text);
            tTipoProducto.Fill(ds.tipoProducto);
            txtNombreTipoProducto.Clear();

            txtNombreTipoProducto.Visible = false;
            lblNombreTipoProducto.Visible = false;
            btnAgregarTipoProducto.Visible = false;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(ds.producto.Rows[ds.producto.Rows.Count - 1].ItemArray[0]);
            int precio = Convert.ToInt32(nudPrecioProducto.Value);
            int idTipoProducto = Convert.ToInt32(cboTipoProducto.SelectedValue);

            tProducto.Insert(idProducto+1, txtNombreProducto.Text, precio, idTipoProducto, txtEstadoProducto.Text);
            tProducto.Fill(ds.producto);

            txtEstadoProducto.Clear();
            txtNombreProducto.Clear();
            nudPrecioProducto.Value = 0;

        }

        private void cboTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
