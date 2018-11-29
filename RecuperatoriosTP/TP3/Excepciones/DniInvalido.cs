using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
            public DniInvalidoException()
                : base("Formato De DNI Invalido.")
            {

            }

            public DniInvalidoException(string message)
                : base(message)
            {

            }
    }

}
