﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T>
    {
        public bool Guardar(string archivo, T datos)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            try
            {
                using (StreamWriter s = new StreamWriter(archivo, true))
                {
                    serializer.Serialize(s, datos);
                }
                return true;

            }
            catch (ArchivosException a)
            {
                throw a;
            }
        }

        public bool Leer(string archivo, out T datos)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            try
            {
                using (StreamReader s = new StreamReader(archivo))
                {
                    datos = (T)serializer.Deserialize(s);
                }
                return true;
            }
            catch (Exception a)
            {

                throw new ArchivosException(a.Message);

            }
        }
    }
}
