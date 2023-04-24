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
    public class CDProductos
    {

        CDconxion Conexion = new CDconxion();
        SqlDataReader leer;
        DataTable Tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public int Codigo;
        public bool Repetido;

        public DataTable buscarproductos(CEproductos productos) 
        {
            comando.Parameters.Clear();
            Tabla.Clear();
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "BuscarPructos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo",productos.Codigo);
            leer= comando.ExecuteReader();
            Tabla.Load(leer);
            Conexion.Cerrarconxion();
            return Tabla;
          
        }

        public DataTable MostrarProductos()
        {
            comando.Parameters.Clear();
            Tabla.Clear();
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "Mostrarproducto";
            comando.CommandType = CommandType.StoredProcedure;
            leer= comando.ExecuteReader();
            Tabla.Load(leer);
            return Tabla;
        }


        public void Insertarproductos(CEproductos  producto)
        {
            comando.Parameters.Clear();
            comando.Connection=Conexion.abrirconexion();
            comando.CommandText = "SP_INSERTARPRODUCT";
            comando.CommandType=CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo", producto.Codigo);
            comando.Parameters.AddWithValue("@Descri", producto.Descripcion);
            comando.Parameters.AddWithValue("@ValUnd", producto.Valor_Unidad);
            comando.Parameters.AddWithValue("@Cantida", producto.Cantidad);
            comando.ExecuteNonQuery();
            Conexion.Cerrarconxion();
        }

        public void Editarproductos(CEproductos producto)
        {
            
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "SP_ACTUALIZARPROD";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("CodNew", producto.Codigo);
            comando.Parameters.AddWithValue("@Descri", producto.Descripcion);
            comando.Parameters.AddWithValue("@ValUnd", producto.Valor_Unidad);
            comando.Parameters.AddWithValue("@Cant", producto.Cantidad);
            comando.Parameters.AddWithValue("@Cod", producto.Codigo);
            comando.ExecuteNonQuery();
            Conexion.Cerrarconxion();
        }

        public void EliminarProdcuto(CEproductos producto)
        {
            comando.Parameters.Clear();
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "SP_ELIMINARPROD";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cod", producto.Codigo);
            comando.ExecuteNonQuery();
            Conexion.Cerrarconxion();
        }

   
        public bool idrepetido(CEproductos producto)
        {
            try
            {

                comando.Parameters.Clear();
                comando.Connection = Conexion.abrirconexion();
                comando.CommandText = "Idrepetido";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Codigo", producto.Codigo);
                leer = comando.ExecuteReader();
                if (leer.Read())
                {

                    Repetido = true;
                    return Repetido;

                }
                else
                {

                    Repetido = false;
                    return Repetido;
                }
            }
            finally
            {
                Conexion.Cerrarconxion();
            }              
        }
        
    
    
    }
}
