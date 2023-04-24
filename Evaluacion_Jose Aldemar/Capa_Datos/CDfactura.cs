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
    public class CDfactura
    {

        CDconxion Conexion = new CDconxion();
        SqlDataReader leer;
        DataTable Tabla = new DataTable();
        SqlCommand comando = new SqlCommand();




        public string Mostrarfactura()
        {
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "BuscarNfactura";
            comando.CommandType = CommandType.StoredProcedure;
            leer=comando.ExecuteReader();
            if (leer.Read() == true)
            {

                string factura= leer["IdFactu"].ToString();
                leer.Close();
                return factura;

            }
            else
            {

                leer.Close();
                return " ";
            }

        }

        public void insertarfactura(CEfacturacion FACT)
        {
            comando.Parameters.Clear();
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "SP_AGGFACT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Fech", FACT.Fecha);
            comando.Parameters.AddWithValue("@DoClient", FACT.Documento_Cliente);
            comando.Parameters.AddWithValue("@CodVende", FACT.Codigo_Vendedor);
            comando.ExecuteNonQuery();
            Conexion.Cerrarconxion();
        }
    }
}
