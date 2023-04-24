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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        CNvariablesglobales CNvariablesglobales=new CNvariablesglobales();
        CEFacturadetalle cefacturadetalle = new CEFacturadetalle();
        CEfacturacion CEfacturacion= new CEfacturacion();
        CNclientes clientes = new CNclientes();
        CNProductos CNProductos= new CNProductos();
        CEproductos CEProductos= new CEproductos();
        CNFacturacion CNFacturacion= new CNFacturacion();
        CNFacturaDetalle CNFacturaDetalle= new CNFacturaDetalle();
        int PrecioSuma = 0;

   

        DataTable Tabla = new DataTable();

        private void Form4_Load(object sender, EventArgs e)
        {
            MostrarFactura();
            cmbClientes();
            cmbProductos();

            Tabla.Columns.Add("#Factura");
            Tabla.Columns.Add("Fecha");
            Tabla.Columns.Add("Clientes");
            Tabla.Columns.Add("Productos");
            Tabla.Columns.Add("Valor");
            Tabla.Columns.Add("Cantidad");
            Tabla.Columns.Add("Subtotal");


            dataGridView1.DataSource= Tabla;

        }



        private void MostrarFactura()
        {

            if(CNFacturacion.MostrarFactura() != " ")
            {
              int  Factura=Convert.ToInt32(CNFacturacion.MostrarFactura()) + 1;
              TxtFactura.Text=Factura.ToString();

            }
            else
              TxtFactura.Text = 1.ToString();


        }

        private void BtnAgregarFactura_Click(object sender, EventArgs e)
        {

            string clien = CmbCliente.SelectedValue.ToString();
            string Proc = CmbProductos.SelectedValue.ToString();

            CEProductos.Codigo = Convert.ToInt32(CmbProductos.SelectedValue);
            DataTable dtProducto = CNProductos.buscarproducto(CEProductos);
            int Precio = Convert.ToInt32(dtProducto.Rows[0]["Valor_Unidad"].ToString());

            DataRow Fila = Tabla.NewRow();
             Fila["#Factura"] = TxtFactura.Text;
             Fila["Fecha"] = DtpFecha.Text;
             Fila["Clientes"] = clien;
             Fila["Productos"] = Proc;
             Fila["Valor"] =(Precio).ToString();
             Fila["Cantidad"]=TxtCantidad.Text;
             Fila["Subtotal"] =(Precio)*(Convert.ToInt32(TxtCantidad.Text));
           
            Tabla.Rows.Add(Fila);
            //TxtTotalFactura.Text = TotalFactura().ToString();
            TotalFactura();
            
            
            cmbProductos();
        }



        public void TotalFactura()
        {

            int valor_Total = 0;

            foreach (DataRow filas in Tabla.Rows)
            {

                valor_Total += Convert.ToInt32(filas["Subtotal"]);

            }
            int Valor = valor_Total;
            TxtTotalFactura.Text = valor_Total.ToString();
                   
            //CEProductos.Codigo = Convert.ToInt32(CmbProductos.SelectedValue);
            //DataTable dtProducto = CNProductos.buscarproducto(CEProductos);
            //int Precio = Convert.ToInt32(dtProducto.Rows[0]["Valor_Unidad"].ToString());
            //int Total = Precio * Convert.ToInt32(TxtCantidad.Text);
            //TxtTotalFactura.Text = Convert.ToString(Total);
            //PrecioSuma =


        }

        #region
        private void cmbClientes()
        {
            CmbCliente.DataSource = clientes.MostrarClientes();
            CmbCliente.ValueMember = "Documento";
            CmbCliente.DisplayMember = "Nombre";
        }

        private void cmbProductos()
        {
            CmbProductos.DataSource = CNProductos.MostrarProd();
            CmbProductos.ValueMember = "Codigo";
            CmbProductos.DisplayMember = "Descripción";
        }







        #endregion

        private void BtnTerminar_Click(object sender, EventArgs e)
        {

            enviarFactura();
            enviarFacturaDetalle();
        }
   
        public void enviarFactura()
        {
            int Vendedor = 1212;
         
                CEfacturacion.Fecha = Convert.ToDateTime(DtpFecha.Value);
                CEfacturacion.Documento_Cliente = Convert.ToInt32(CmbCliente.SelectedValue);
                CEfacturacion.Codigo_Vendedor =Vendedor;
                CNFacturacion.InsetarFactura(CEfacturacion);  
        }
        public void enviarFacturaDetalle()
        {

          
            foreach (DataRow Datarow in Tabla.Rows)
            {
                cefacturadetalle.IDfac = Convert.ToInt32(Datarow["#Factura"]);
                cefacturadetalle.CodProd = Convert.ToInt32(Datarow["Productos"]);
                cefacturadetalle.Cant = Convert.ToInt32(Datarow["Cantidad"]);
                cefacturadetalle.Valunidad = Convert.ToInt32(Datarow["Valor"]);
                CNFacturaDetalle.InsetarFacturaDetalle(cefacturadetalle);
            }

        }

    }
}
