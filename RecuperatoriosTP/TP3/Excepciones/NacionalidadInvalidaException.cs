using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        public NacionalidadInvalidaException()
            : base("La Nacionalidad No Coincide Con El Numero De DNI")
        {

        }

        public NacionalidadInvalidaException(string message)
            : base(message)
        {

        }
    }
}
