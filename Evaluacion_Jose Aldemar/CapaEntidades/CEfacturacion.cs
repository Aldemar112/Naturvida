using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CapaEntidades
{
    public class CEfacturacion
    {
        public int Idfactu { get; set; }

        public DateTime Fecha { get; set; }

        public int Documento_Cliente { get; set; }

        public int Codigo_Vendedor { get; set; }
   
    }
}
