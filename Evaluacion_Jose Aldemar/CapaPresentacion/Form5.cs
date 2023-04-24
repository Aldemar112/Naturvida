using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class Form5 : Form
    {

        CEClientes CEClientes= new CEClientes();
        CNclientes CNclientes= new CNclientes();
        CNvalidaciones CNvalid= new CNvalidaciones();
        public Form5()
        {
            InitializeComponent();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            CEClientes.Documento=Convert.ToInt32(TxtDocumento.Text);
            CEClientes.Nombre=TxtNombre.Text;
            CEClientes.Direccion=TxtDireccion.Text;
            CEClientes.Telefono=TxtTelefono.Text;
            CEClientes.Correo=Txtcorreo.Text;
            CNclientes.Insertarcliente(CEClientes);
            MessageBox.Show("Se inserto");
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            int Codigo;
            Codigo = Convert.ToInt32(CmbCliente.SelectedValue.ToString());
            CEClientes.Documento = Codigo;
            DgvCliente.DataSource =CNclientes.buscarCliente(CEClientes);    
        }

   

        private void Form5_Load(object sender, EventArgs e)
        {
            Mostrarcliente();
            BuscracmbCliente();
            BuscracmbClienteL();
            BuscracmbClienteD();
           
        }



        #region

        public void Mostrarcliente()
        {

            DgvCliente.DataSource = CNclientes.MostrarClientes();

        }
        private void BuscracmbCliente()
        {
            CmbCliente.DataSource = CNclientes.MostrarClientes();
            CmbCliente.ValueMember = "Documento";
            CmbCliente.DisplayMember = "Nombre";
        }



        private void BuscracmbClienteD()
        {
            CmbClienteeditar.DataSource = CNclientes.MostrarClientes();
            CmbClienteeditar.ValueMember = "Documento";
            CmbClienteeditar.DisplayMember = "Nombre";

        }

        private void BuscracmbClienteL()
        {
            cmbeliminarC.DataSource = CNclientes.MostrarClientes();
            cmbeliminarC.ValueMember = "Documento";
            cmbeliminarC.DisplayMember = "Nombre";

        }

        public void Limpiar()
        {

            Txtcorreo.Clear();
            TxtDireccion.Clear();
            TxtDocumento.Clear();
            TxtNombre.Clear();
            TxtTelefono.Clear();
        }

        #endregion

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            Mostrarcliente();
        }

        private void BtnConsulatrD_Click(object sender, EventArgs e)
        {
            if (CmbClienteeditar.SelectedIndex >= 0)
            {
                TxtDocumentoD.Text = DgvCliente.CurrentRow.Cells["Documento"].Value.ToString();
                TxtNombreD.Text = DgvCliente.CurrentRow.Cells["Nombre"].Value.ToString();
                TxtDireccionD.Text = DgvCliente.CurrentRow.Cells["Direccion"].Value.ToString();
                TxtelefonoD.Text = DgvCliente.CurrentRow.Cells["Telefono"].Value.ToString();
                TxtCorreoD.Text = DgvCliente.CurrentRow.Cells["Correo"].Value.ToString();

            }
        }

        private void CmbClienteeditar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            CEClientes.Documento = Convert.ToInt32(TxtDocumentoD.Text);
            CEClientes.DocumentoNew= Convert.ToInt32(TxtDocumentoD.Text);
            CEClientes.Nombre = TxtNombreD.Text;
            CEClientes.Direccion=TxtDireccionD.Text;
            CEClientes.Telefono = TxtelefonoD.Text;
            CEClientes.Correo=TxtCorreoD.Text;
            CNclientes.ActualizarCliente(CEClientes);
            MessageBox.Show("Se edito correctamente");
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            CEClientes.Documento = Convert.ToInt32(CEClientes.Documento.ToString());
            CNclientes.Eliminarcliente(CEClientes);
            MessageBox.Show("Eliminado Correectamente");
        }

        private void Txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                //if (CNvalid.ValidarEmail(Txtcorreo.Text) == false)
                //{
                //    lblValido.Text = "DIRECCIÓN INVALIDA";
                //    lblValido.ForeColor = Color.Red;
                //}
                //else
                //{
                //    lblValido.Text = "DIRECCIÓN VALIDA";
                //    lblValido.ForeColor = Color.Green;
                //}
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TxtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            CNvalid.Solonumeros(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            CNvalid.Solonumeros(e);
        }
    }
}
