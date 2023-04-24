using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaNegocio
{
    public class CNProductos
    {

        CDProductos CDProductos= new CDProductos();
        public bool Idrepertido;

        public DataTable MostrarProd()
        {
            DataTable dt= new DataTable();
            dt=CDProductos.MostrarProductos();
            return dt;
        }

        public DataTable buscarproducto(CEproductos Productos)
        {
            DataTable dt = new DataTable();
            dt = CDProductos.buscarproductos(Productos);
            return dt;
        }

        public void InsertarProducto(CEproductos productos)
        {
            CDProductos.Insertarproductos(productos);
        }

        public void editarprodcuto(CEproductos productos)
        {
            CDProductos.Editarproductos(productos);
        }

        public void Eliminarprductos(CEproductos productos)
        {

            CDProductos.EliminarProdcuto(productos);
        }

        public bool idrepetido(CEproductos productos)
        {
            CDProductos.idrepetido(productos);
            if (CDProductos.Repetido==true)
            {
                Idrepertido = true;
                return Idrepertido;

            }
            else
            {
                 Idrepertido =false;
                 return Idrepertido;
            }
        }


    }
}
