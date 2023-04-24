using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CapaPresentacion
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        CEvendedores CEvendedores = new CEvendedores();
        CNvendedores CNvendedores=new CNvendedores();

        private void Form6_Load(object sender, EventArgs e)
        {
            MostarVendedores();
            BuscracmbV();
            BuscracmbVE();
            BuscracmbVEL();

        }


        private void BtnInsertar_Click(object sender, EventArgs e)
        {

            CEvendedores.Codigo =Convert.ToInt32(TxtCodigo.Text);
            CEvendedores.Usuario=TxtContrasena.Text;
            CEvendedores.Contraseña=encryptar( TxtContrasena.Text);
            CEvendedores.Nombre=TxtNombre.Text;
            CNvendedores.InsertarVendores(CEvendedores);

        }


        #region

        public void MostarVendedores()
        {
        
            DgvVendores.DataSource = CNvendedores.MostrarVendedores();
        
        }
        private void BuscracmbV()
        {
            CmbConsultarVen.DataSource = CNvendedores.MostrarVendedores();
            CmbConsultarVen.ValueMember = "Codigo";
            CmbConsultarVen.DisplayMember = "Nombre";
        }

        private void BuscracmbVEL()
        {
            cmbeliminarV.DataSource = CNvendedores.MostrarVendedores();
            cmbeliminarV.ValueMember = "Codigo";
            cmbeliminarV.DisplayMember = "Nombre";
        }

        private void BuscracmbVE()
        {
            cmbeditarV.DataSource = CNvendedores.MostrarVendedores();
            cmbeditarV.ValueMember = "Codigo";
            cmbeditarV.DisplayMember = "Nombre";
        }



        public static string encryptar(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            Byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        #endregion

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            int Codigo;
            Codigo = Convert.ToInt32(CmbConsultarVen.SelectedValue.ToString());
            CEvendedores.Codigo = Codigo;
            DgvVendores.DataSource = CNvendedores.buscarVendores(CEvendedores);
        }


        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            MostarVendedores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbeditarV.SelectedIndex >= 0)
            {
                TxtCodigo1.Text = DgvVendores.CurrentRow.Cells["Codigo"].Value.ToString();
                TxtUsuario1.Text = DgvVendores.CurrentRow.Cells["Usuario"].Value.ToString();
                Txtcontrasena1.Text = DgvVendores.CurrentRow.Cells["Contraseña"].Value.ToString();
                Txtnombre1.Text = DgvVendores.CurrentRow.Cells["Nombre"].Value.ToString();
            }
        }


        private void Btneliminar_Click_1(object sender, EventArgs e)
        {
            CEvendedores.Codigo = Convert.ToInt32(cmbeditarV.SelectedValue.ToString());
            CNvendedores.EliminarVendores(CEvendedores);
            MessageBox.Show("Eliminado Correectamente");
        }
    }
}
