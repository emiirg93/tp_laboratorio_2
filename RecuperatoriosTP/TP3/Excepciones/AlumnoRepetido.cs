using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class AlumnoRepetidoException : Exception
    {
        public AlumnoRepetidoException()
            : base("Alumno Repetido.")
        {

        }

        public AlumnoRepetidoException(string message)
            : base(message)
        {

        }
    }
}
