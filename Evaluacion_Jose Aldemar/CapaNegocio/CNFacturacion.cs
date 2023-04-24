using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using Capa_Datos;



namespace CapaNegocio
{
    public class CNFacturacion
    {

        CDfactura CDFactura = new CDfactura();

        public string MostrarFactura()
        {
            string Factura = CDFactura.Mostrarfactura();
            return Factura;

        }

        public void InsetarFactura(CEfacturacion Fact)
        {
            CDFactura.insertarfactura(Fact);
        }

    }
}
