using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        public Universitario()
        {
                 
        }

        public Universitario(int legajo, string nombre, string apellido , string dni, ENacionalidad nacionalidad) : base (nombre,apellido,nacionalidad,dni)
        {
            this.legajo = legajo;
        }

        protected virtual string MostrarDatos()
        {
            return base.ToString() + "\n\nLegajo Numero : " + this.legajo.ToString();
        }

        protected abstract string ParticiparEnClase();

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool tof = false;

            if(pg1 is Universitario && pg2 is Universitario)
            {
                if(pg1.legajo == pg2.legajo && pg1.DNI == pg2.DNI)
                {
                    tof = true;
                }
            }

            return tof;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        public override bool Equals(object obj)
        {
            bool tof = false;

            if (obj is Universitario)
            {
                tof = true;
            }

            return tof;
        }

    }
}
