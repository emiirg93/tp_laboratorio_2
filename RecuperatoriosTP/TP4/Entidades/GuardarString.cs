using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class GuardarString
    {
        public static bool Guardar(this string texto, string archivo)
        {
            bool tof = false;

            try
            {
                using(System.IO.StreamWriter file = new System.IO.StreamWriter(archivo,true))
                {
                    file.WriteLine(texto);
                    file.Close();
                    tof = true;
                }
            }
            catch (Exception)
            {
                
            }

            return tof;
        }
    }
}
