using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using CapaEntidades;

namespace CapaNegocio
{
    public class CNvendedores
    {

        CDvendores CDvendedores= new CDvendores();

        public bool buscarUsuario(CEvendedores INFO)
        {
            CDvendedores.buscarvendores(INFO);
            if (INFO.Contraseña == CDvendedores.password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public DataTable buscarVendores(CEvendedores Vendores)
        {
            DataTable dt = new DataTable();
            dt = CDvendedores.buscarVendores(Vendores);
            return dt;
        }

        public DataTable MostrarVendedores()
        {
            DataTable dt = new DataTable();
            dt = CDvendedores.MostrarVendores();
            return dt;
        }

        public void InsertarVendores(CEvendedores Vendores)
        {
            CDvendedores.InsertarVendedores(Vendores);
        }

        public void EliminarVendores(CEvendedores Vendores)
        {
            CDvendedores.EliminarVendores(Vendores);
        }
        public void ActualizarVendores(CEvendedores Vendores)
        {
            CDvendedores.Editarvendodores(Vendores);
        }

    }
}
