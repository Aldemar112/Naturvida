using CapaEntidades;
using CapaNegocio;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        CNinventario CNinventario=new CNinventario();
        CNProductos CNProductos=new CNProductos();
        CEproductos CEproductos=new CEproductos();
        private void Form8_Load(object sender, EventArgs e)
        {
            MostrarInventarios();
            Buscracmb();
        }


        #region

        public void MostrarInventarios()
        {
            DgvInventario.DataSource =  CNinventario.MostrarInventario();
        }


        private void Buscracmb()
        {
            comboBox1.DataSource = CNProductos.MostrarProd();
            comboBox1.ValueMember = "Codigo";
            comboBox1.DisplayMember = "Descripción";
        }


        public void ExportarDatos(DataGridView DgvProductos)
        {

            Microsoft.Office.Interop.Excel.Application exportarexcel = new Microsoft.Office.Interop.Excel.Application();//creamos un objecto de tipo apllicacion microsoft office 

            exportarexcel.Application.Workbooks.Add(true); //le decimos que creamos una nueva hoja de tyrabajo

            int indicecolumna = 0; //pasamos a leer las columnas 

            foreach (DataGridViewColumn columns in DgvProductos.Columns)//con el foreach vamos recorriendo todas las columnas, se le hace refrencia al datagreview 
            {

                indicecolumna++;//va aumnetando ell estado

                exportarexcel.Cells[1, indicecolumna] = columns.Name; //va insertando el nombre de nuestra columna en excel          
            }

            // se procede hacer lo mismo con la fila
            int indicefila = 0;

            foreach (DataGridViewRow fila in DgvProductos.Rows)//se pasa a leer las filas con un foreach
            {
                indicefila++;//va aumentando las filas
                indicecolumna = 0;


                //volvermos a leer las columnas 
                foreach (DataGridViewColumn columna in DgvProductos.Columns)
                {
                    indicecolumna++;
                    //se inserta a excel en la propiedad cell 
                    exportarexcel.Cells[indicefila + 1, indicecolumna] = fila.Cells[columna.Name].Value;

                }
            }

            exportarexcel.Visible = true; //con esto mostramos el archivo excel

        }


        #endregion

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            int Codigo;
            Codigo = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            CEproductos.Codigo = Codigo;
            DgvInventario.DataSource = CNinventario.buscarinventario(CEproductos);
        }

        private void Btnexecel_Click(object sender, EventArgs e)
        {
            ExportarDatos(DgvInventario);
        }
   
    }
}
