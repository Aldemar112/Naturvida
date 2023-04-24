using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;


namespace CapaPresentacion
{
    public partial class Form3 : Form
    {
        int codigo;
        public Form3()
        {
            this.codigo = codigo;
            InitializeComponent();
        }

        CNProductos CNProductos= new CNProductos();
        CEproductos CEproductos= new CEproductos();
        CNvalidaciones CNvalid= new CNvalidaciones();
        private void Form3_Load(object sender, EventArgs e)
        {
            MostrarProdcutos();
            Buscracmb();
            Buscracmb2();
            Buscracmb3();
        }


        #region

        public void MostrarProdcutos()
        {
          DgvProductos.DataSource = CNProductos.MostrarProd();
        }

       public void limpiarinsertar()
       {
            TxtCantidad.Clear();
            TxtCodigo.Clear();
            TxtDescripcion.Clear();
            TxtValorunidad.Clear();
       }
        public void limpiarEditar()
        {
            TxtCantidad1.Clear();
            TxtCodigo1.Clear();
            TxtDescripcion1.Clear();
            TxtValor1.Clear();
        }



        #endregion

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            MostrarProdcutos();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {

            CEproductos.Codigo=Convert.ToInt32(TxtCodigo.Text);
            CEproductos.Descripcion=TxtDescripcion.Text;
            CEproductos.Valor_Unidad =Convert.ToInt32(TxtValorunidad.Text);
            CEproductos.Cantidad = Convert.ToInt32(TxtCantidad.Text);
            CNProductos.InsertarProducto(CEproductos);
            MessageBox.Show("Se inserto correctamente");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    string prueba=comboBox1.Se;
            //}
        }

        private void Buscracmb3()
        {
            cmbeliminar.DataSource = CNProductos.MostrarProd();
            cmbeliminar.ValueMember = "Codigo";
            cmbeliminar.DisplayMember = "Descripción";
        }


        private void Buscracmb()
        {
            comboBox1.DataSource = CNProductos.MostrarProd();
            comboBox1.ValueMember = "Codigo";
            comboBox1.DisplayMember = "Descripción";
        }

        private void Buscracmb2()
        {
            cmbeditarC.DataSource = CNProductos.MostrarProd();
            cmbeditarC.ValueMember = "Codigo";
            cmbeditarC.DisplayMember = "Descripción";
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                int Codigo;
                Codigo=Convert.ToInt32(comboBox1.SelectedValue.ToString());
                CEproductos.Codigo=Codigo;
                DgvProductos.DataSource=CNProductos.buscarproducto(CEproductos);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Holi " + ex);
            }
          
            //CNProductos.buscarproducto(CEproductos);
        }

        private void cmbeditar_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbeditarC.SelectedIndex >= 0)
            {
                TxtCodigo1.Text = DgvProductos.CurrentRow.Cells["codigo"].Value.ToString();
                TxtDescripcion1.Text = DgvProductos.CurrentRow.Cells["Descripción"].Value.ToString();
                TxtValor1.Text = DgvProductos.CurrentRow.Cells["Valor_unidad"].Value.ToString();
                TxtCantidad1.Text = DgvProductos.CurrentRow.Cells["Cantidad"].Value.ToString();
            } 
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            CEproductos.Codigo = Convert.ToInt32(TxtCodigo1.Text);
            CEproductos.Descripcion = TxtDescripcion1.Text;
            CEproductos.Valor_Unidad = Convert.ToInt32(TxtValor1.Text);
            CEproductos.Cantidad = Convert.ToInt32(TxtCantidad1.Text);
            CNProductos.editarprodcuto(CEproductos);
            limpiarEditar();
            MessageBox.Show("Se edito correctamente");

        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            CEproductos.Codigo = Convert.ToInt32(cmbeliminar.SelectedValue.ToString());
            CNProductos.Eliminarprductos(CEproductos);
            MessageBox.Show("Eliminado Correectamente");
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (TxtCodigo.Text == " ")
                {
                    MessageBox.Show("Tiene que llenar en campo");
                }

                else
                {
                    CEproductos.Codigo = Convert.ToInt32(TxtCodigo.Text);
                    CNProductos.idrepetido(CEproductos);

                    if (CNProductos.Idrepertido == true)
                    {
                        lblrepetido.Text = "El codigo ya exixte";

                    }
                    else
                    {
                        lblrepetido.Text = " ";

                    }

                }
            }
            catch
            {
                
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        //validaciones
        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            CNvalid.Solonumeros(e);
        }

        private void TxtValorunidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            CNvalid.Solonumeros(e);
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            CNvalid.Solonumeros(e);
        }

        private void TxtCodigo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CNvalid.Solonumeros(e);
        }

        private void TxtValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CNvalid.Solonumeros(e);
        }

        private void TxtCantidad1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CNvalid.Solonumeros(e);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarinsertar();
        }
    }
}
