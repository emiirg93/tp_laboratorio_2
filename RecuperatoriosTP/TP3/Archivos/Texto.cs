using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Archivos
{
    public class Texto
    {

        public bool Guardar(string archivo, string datos)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(archivo,true))
                {
                   sw.WriteLine(datos);
                   return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Leer(string archivos, out string datos)
        {
            try
            {
                datos = "";

                using (StreamReader sw = new StreamReader(archivos))
                {
                    datos = sw.ReadToEnd();
                    return true;
                }
            }
            catch (Exception e)
            {
                datos = "No se pudo leer el archivo";
                Console.WriteLine(e.Message);
                return false;
            }      
        }
    }
}
