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
    public partial class frmDescuento1 : Form
    {
        public frmDescuento1()
        {
            InitializeComponent();
        }

        DSimprenta ds = new DSimprenta();
        DSimprentaTableAdapters.descuentoTableAdapter descuento = new DSimprentaTableAdapters.descuentoTableAdapter();


        private void frmDescuento_Load(object sender, EventArgs e)
        {
             descuento.Fill(ds.descuento);
            cboIDdes.DataSource = ds.descuento;
            cboIDdes.DisplayMember = "idDescuento";
            cboIDdes.ValueMember = "descuentoPorcentaje";


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int cant;
            double subt, imp, desc, tot, prec;
            cant = int.Parse(this.TxtCant.Text);
            prec = int.Parse(this.TxtPrecio.Text);
            subt = cant * prec;
            //ACA SELECCIONAMOS EL ID DE  DESCUENTO EN LAS OBCIONES DEL COMBO Y SOLO HAY QUE AÑADIR LOS DESCUENTOS
            if (this.cboIDdes.SelectedIndex == 0)
            {
                desc = subt * 0.15;
            }
            else
            {
                desc = subt * 0.10;
            }
            imp = subt * 0.10;
            tot =(subt + imp) - desc;
            this.TxtSubtotal.Text = subt.ToString();
            this.TxtDescuento.Text = desc.ToString();
            this.Txttotalapagar.Text = tot.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
