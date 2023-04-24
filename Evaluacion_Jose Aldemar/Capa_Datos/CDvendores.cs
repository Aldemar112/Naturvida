using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace Capa_Datos
{
    public class CDvendores
    {
        CEvendedores CEvendedores= new CEvendedores();
        CDconxion Conexion = new CDconxion();
        SqlDataReader leer;
        DataTable Tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public string login;
        public string password;
        public bool estado;

        public void buscarvendores(CEvendedores Info) //buscar si ub usuario ya esta registado
        {
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "Buscarvendedores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre",Info.Usuario);
            SqlDataReader consulta = comando.ExecuteReader();
            if (consulta.Read())
            {
                this.login = consulta["nombre"].ToString();
                this.password = consulta["Contraseña"].ToString();
            }
            else
            {
                this.password = "";
            }
            comando.Parameters.Clear();
            Conexion.Cerrarconxion();
        }

        public DataTable buscarVendores(CEvendedores Vendedores)
        {
            comando.Parameters.Clear();
            Tabla.Clear();
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "BuscarVendores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo", Vendedores.Codigo);
            leer = comando.ExecuteReader();
            Tabla.Load(leer);
            Conexion.Cerrarconxion();
            return Tabla;

        }


        public DataTable MostrarVendores()
        {
            comando.Parameters.Clear();
            Tabla.Clear();
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "MostrarVendores";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            Tabla.Load(leer);
            return Tabla;
        }


        public void InsertarVendedores(CEvendedores Vendores)
        {
            comando.Parameters.Clear();
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "SP_INSERTARVENDORES";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo", Vendores.Codigo);
            comando.Parameters.AddWithValue("@Usuario", Vendores.Usuario);
            comando.Parameters.AddWithValue("@Contraseña", Vendores.Contraseña);
            comando.Parameters.AddWithValue("@Nombre", Vendores.Nombre);
            comando.ExecuteNonQuery();
            Conexion.Cerrarconxion();
        }

        public void Editarvendodores(CEvendedores Vendores)
        {
            comando.Parameters.Clear();
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "SP_ACTUALIZARVENDORES";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo", Vendores.Codigo);
            comando.Parameters.AddWithValue("@Usuario", Vendores.Usuario);
            comando.Parameters.AddWithValue("@Contraseña", Vendores.Contraseña);
            comando.Parameters.AddWithValue("@Nombre", Vendores.Nombre);
            comando.ExecuteNonQuery();
            Conexion.Cerrarconxion();
        }

        public void EliminarVendores(CEvendedores Vendores)
        {
            comando.Parameters.Clear();
            comando.Connection = Conexion.abrirconexion();
            comando.CommandText = "SP_ELIMINARVEND";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo", Vendores.Codigo);
            comando.ExecuteNonQuery();
            Conexion.Cerrarconxion();
        }

    }
}
