using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TrackingIDRepetidoException : Exception
    {
        public TrackingIDRepetidoException(string mensaje, Exception inner)
            : base(mensaje, inner)
        {

        }

        public TrackingIDRepetidoException(string mensaje)
            : this(mensaje, null)
        {

        }

    }
}
