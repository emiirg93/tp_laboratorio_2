using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        public ArchivosException()
            : base("Ha Ocurrido Un Error En El Archivo.")
        {

        }

        public ArchivosException(string message)
            : base(message)
        {

        }
    }
}
