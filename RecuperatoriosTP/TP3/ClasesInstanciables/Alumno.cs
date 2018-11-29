using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesAbstractas;
using Excepciones;

namespace ClasesInstanciables
{
    

    public sealed class Alumno : Universitario
    {

        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        

        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        public Alumno()
            : base()
        {

        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        protected override string ParticiparEnClase()
        {
            return "Toma Clases de : " + this.claseQueToma;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Estado De Cuenta : " + this.estadoCuenta);
            sb.AppendLine(this.ParticiparEnClase());

            return sb.ToString();  
        }

        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            bool tof = false;

            if(a.estadoCuenta != EEstadoCuenta.Deudor && a.claseQueToma == clase)
            {
                tof = true;
            }

            return tof;
        }

        public static bool operator != (Alumno a, Universidad.EClases clase)
        {
            return !(a == clase);
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
