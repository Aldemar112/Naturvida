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
using System.Security.Cryptography;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CNvendedores CNvendedores = new CNvendedores();
        CEvendedores CEvendedores = new CEvendedores();   
        CNvariablesglobales CNvariablesglobales= new CNvariablesglobales();



        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            

            CEvendedores.Usuario = TxtUsuario.Text;
            CEvendedores.Contraseña = encryptar(TxtContraseña.Text);
            if (CNvendedores.buscarUsuario(CEvendedores))
            {
                CNvariablesglobales.VendedorGlobal.vendedor1 =TxtUsuario.Text;
                Form2 Menu= new Form2();
                this.Hide();
                Menu.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Rechazado");
            }
            
        }

        #region
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
