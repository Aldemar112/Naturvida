using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace CapaNegocio
{
    public class CNvalidaciones
    {

        public void Solonumeros(KeyPressEventArgs i)
        { 
            if((i.KeyChar >=32 && i.KeyChar <=47)  ||  (i.KeyChar >=58 &&  i.KeyChar <= 255))
            {

                MessageBox.Show("Solo numeros ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                i.Handled = true;
                return;

            }
        }

        public bool ValidarEmail(string comprobarEmail)
        {
            string emailFormato;
            emailFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(comprobarEmail, emailFormato))
            {
                if (Regex.Replace(comprobarEmail, emailFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
