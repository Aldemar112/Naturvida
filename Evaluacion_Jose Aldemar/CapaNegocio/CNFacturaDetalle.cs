using Capa_Datos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNFacturaDetalle
    {
        CDfacturaDetalle Factura = new CDfacturaDetalle();

        public void InsetarFacturaDetalle(CEFacturadetalle Fact)
        {
            Factura.insertarfacturaDetalle(Fact);
        }
    }
}
