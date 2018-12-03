using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        private string messege;

        public DniInvalidoException(string mensaje, Exception e)
            : base(mensaje, e)
        {
            this.messege = mensaje;
        }
        public DniInvalidoException(string mensaje)
            : this(mensaje, null)
        {

        }
        public DniInvalidoException(Exception e)
            : this("", e)
        {

        }
        public DniInvalidoException()
            : this("")
        {

        }
    }

}
