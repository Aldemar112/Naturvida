using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CDinventario
    {


        CDconxion Conexion = new CDconxion();
        SqlDataReader leer;
        DataTable Tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarInventario()
        {
            comando.Parameters.Clear();
            Tabla.Clear();
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "SP_BUSCARINVENTARIOS";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            Tabla.Load(leer);
            return Tabla;
        }

        public DataTable buscarinventario(CEproductos productos)
        {
            comando.Parameters.Clear();
            Tabla.Clear();
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "SP_BUSCARINVENTARIO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Prod", productos.Codigo);
            leer = comando.ExecuteReader();
            Tabla.Load(leer);
            Conexion.Cerrarconxion();
            return Tabla;

        }

    }
}
