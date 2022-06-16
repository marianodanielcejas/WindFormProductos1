using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindFormProductos1
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

       

        private void btCargar_Click(object sender, EventArgs e)
        {

            Producto NuevoProducto;
            NuevoProducto = new Producto(int.Parse(txtCodigo.Text), txtDescripcion.Text);

            lblCodigoMov.Text = NuevoProducto.p_codigo.ToString();
            lblDescripMov.Text = NuevoProducto.p_descripcion;
            lbl_StockMov.Text = "Hay " + NuevoProducto.p_stock.ToString() + " Unidades";

            MessageBox.Show("Producto Instanciado");
        }
        private void btAceptar_Click(object sender, EventArgs e)
        {
        }

    }
}
