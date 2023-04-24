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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void abirrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Openfiledialog ofd= New openFileDialog 
            Ofd1.Filter = "Archivo sql (*.sql)|*.sql";
            Ofd1.Title = "Abrir";
            Ofd1.InitialDirectory = @"C:\Users\Sena CSET\Desktop\Evalucionnn\Evalucionnn\Evalucion";
            if (Ofd1.ShowDialog() == DialogResult.OK)
            {

                Txtabrir.Text = Ofd1.FileName;            
            
            }
            Ofd1.Dispose();
        }
    
        Button Botn= new Button();
    }
}
