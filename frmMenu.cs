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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menProducto_Click(object sender, EventArgs e)
        {
            frmProducto prod = new frmProducto();
            prod.ShowDialog();
        }

        private void menOrdenTrabajo_Click(object sender, EventArgs e)
        {
            frmOrdenTrabajo orden = new frmOrdenTrabajo();
            orden.ShowDialog();
        }

        private void menDescuentos_Click(object sender, EventArgs e)
        {
            
        }

        private void menCliente_Click(object sender, EventArgs e)
        {

        }

        private void descuentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDescuento1 orden = new frmDescuento1();
            orden.ShowDialog();
        }
    }
}
