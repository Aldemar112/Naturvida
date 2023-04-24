using Capa_Datos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNinventario
    {

        CDinventario CDinventario = new CDinventario();

        public DataTable MostrarInventario()
        {
            DataTable dt = new DataTable();
            dt = CDinventario.MostrarInventario();
            return dt;
        }
        public DataTable buscarinventario(CEproductos Productos)
        {
            DataTable dt = new DataTable();
            dt = CDinventario.buscarinventario(Productos);
            return dt;
        }


    }
}
