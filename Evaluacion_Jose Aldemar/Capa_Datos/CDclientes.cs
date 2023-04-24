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
    public class CDclientes
    {

        CDconxion Conexion = new CDconxion();
        SqlDataReader leer;
        DataTable Tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public DataTable buscarcliente(CEClientes clientes)
        {
            comando.Parameters.Clear();
            Tabla.Clear();
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "BuscarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Documento",clientes.Documento);
            leer = comando.ExecuteReader();
            Tabla.Load(leer);
            Conexion.Cerrarconxion();
            return Tabla;

        }

        public DataTable MostraClientes()
        {
            comando.Parameters.Clear();
            Tabla.Clear();
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "MostrarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            Tabla.Load(leer);
            return Tabla;
        }

        public void InsertarClientes(CEClientes Clientes)
        {
            comando.Parameters.Clear();
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "SP_INSERTARCLIENT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Docu", Clientes.Documento);
            comando.Parameters.AddWithValue("@Nombre", Clientes.Nombre);
            comando.Parameters.AddWithValue("@Direccion", Clientes.Direccion);
            comando.Parameters.AddWithValue("@Tel", Clientes.Telefono);
            comando.Parameters.AddWithValue("@Corr", Clientes.Correo);
            comando.ExecuteNonQuery();
            Conexion.Cerrarconxion();
        }


        public void ActualizarClientes(CEClientes Clientes)
        {
            comando.Parameters.Clear();
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "SP_ACTUALCLIENT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Docu", Clientes.Documento);
            comando.Parameters.AddWithValue("@DocuNew", Clientes.DocumentoNew);
            comando.Parameters.AddWithValue("@Nombre", Clientes.Nombre);
            comando.Parameters.AddWithValue("@Direccion", Clientes.Direccion);
            comando.Parameters.AddWithValue("@Tel", Clientes.Telefono);
            comando.Parameters.AddWithValue("@Corr", Clientes.Correo);
            comando.ExecuteNonQuery();
            Conexion.Cerrarconxion();
        }

        public void EliminarClientes(CEClientes Clientes)
        {
            comando.Parameters.Clear();
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "SP_ELIMINARCLIENT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Docu", Clientes.Documento);
            comando.ExecuteNonQuery();
            Conexion.Cerrarconxion();
        }



    }
}
