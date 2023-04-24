using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {

            InitializeComponent();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            Form3 Productos = new Form3();
            this.Hide();
            Productos.ShowDialog();
            this.Show();

        }

        private void BtnFacturacion_Click(object sender, EventArgs e)
        {
            Form4 Facturacion = new Form4();
            this.Hide();
            Facturacion.ShowDialog();
            this.Show();
        }

        private void Btncliente_Click(object sender, EventArgs e)
        {
            Form5 Cliente = new Form5();
            this.Hide();
            Cliente.ShowDialog();
            this.Show();
        }

        private void BtnVendores_Click(object sender, EventArgs e)
        {
            Form6 Vendedores = new Form6();
            this.Hide();
            Vendedores.ShowDialog();
            this.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            Form8 Inventario = new Form8();
            this.Hide();
            Inventario.ShowDialog();
            this.Show();
        }
    }
}
