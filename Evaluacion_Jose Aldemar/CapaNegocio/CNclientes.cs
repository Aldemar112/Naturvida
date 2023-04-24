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
    public class CNclientes
    {

        CDclientes clientes = new CDclientes();


        public DataTable buscarCliente(CEClientes ceclientes)
        {
            DataTable dt = new DataTable();
            dt =clientes.buscarcliente(ceclientes);
            return dt;
        }

        public DataTable MostrarClientes()
        {
            DataTable dt = new DataTable();
            dt = clientes.MostraClientes();
            return dt;
        }

        public void Insertarcliente(CEClientes ceclientes)
        {
            clientes.InsertarClientes(ceclientes);
        }

        public void Eliminarcliente(CEClientes ceclientes)
        {
            clientes.EliminarClientes(ceclientes);
        }
        public void ActualizarCliente(CEClientes ceclientes)
        {
            clientes.ActualizarClientes(ceclientes);
        }

    }
}
