using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace Capa_Datos
{
    public class CDfacturaDetalle
    {

        CDconxion Conexion = new CDconxion();
        SqlDataReader leer;
        DataTable Tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void insertarfacturaDetalle(CEFacturadetalle FACT)
        {
            comando.Parameters.Clear();
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "SP_AGGFACTDETA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDFac", FACT.IDfac);
            comando.Parameters.AddWithValue("@CodProd", FACT.CodProd);
            comando.Parameters.AddWithValue("@Cant", FACT.Cant);
            comando.Parameters.AddWithValue("@ValUnidad", FACT.Valunidad);
            comando.ExecuteNonQuery();
            Conexion.Cerrarconxion();
        }

        public void ActualizarCantidad(CEFacturadetalle factura)
        {
            comando.Parameters.Clear();
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "SP_DESCONTARCANT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codprod", factura.CodProd);
            comando.Parameters.AddWithValue("@Cantidad", factura.Cant);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            Conexion.Cerrarconxion();
        }
    }
}
