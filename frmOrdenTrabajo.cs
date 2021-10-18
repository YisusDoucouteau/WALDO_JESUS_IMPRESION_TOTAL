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
    public partial class frmOrdenTrabajo : Form
    {
        public frmOrdenTrabajo()
        {
            InitializeComponent();
        }
        //conectando la base de datos y las tablas
        DSimprenta ds = new DSimprenta();
        DSimprentaTableAdapters.productoTableAdapter tProducto = new DSimprentaTableAdapters.productoTableAdapter();
        DSimprentaTableAdapters.detalleOrdenTrabajoTableAdapter tDetalleOrdenTrabajo = new DSimprentaTableAdapters.detalleOrdenTrabajoTableAdapter();
        DSimprentaTableAdapters.ordenTrabajoTableAdapter tOrdenTrabajo = new DSimprentaTableAdapters.ordenTrabajoTableAdapter();


        private void frmOrdenTrabajo_Load(object sender, EventArgs e)
        {
            tProducto.Fill(ds.producto);
            tDetalleOrdenTrabajo.Fill(ds.detalleOrdenTrabajo);
            tOrdenTrabajo.Fill(ds.ordenTrabajo);

            //cargando al data gridview
            dgvProducto.DataSource = ds.producto;
            dgvProducto.Columns[3].Visible = false;
            dgvProducto.Columns[4].Visible = false;
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
