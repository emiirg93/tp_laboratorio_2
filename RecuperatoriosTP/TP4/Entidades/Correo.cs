using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {

        #region Atributos.

        List<Thread> mockPaquetes;
        List<Paquete> paquetes;

        #endregion

        #region Propiedades.

        public List<Paquete> Paquetes
        {
            get { return this.paquetes; }
            set { this.paquetes = value; }
        }

        #endregion

        #region Metodos Y Propiedades.

        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.paquetes = new List<Paquete>();
        }

        public void FinEntregas()
        {
            foreach (Thread item in this.mockPaquetes)
            {
                if (item.IsAlive)
                {
                    item.Abort();
                }
            }
        }

        public static Correo operator +(Correo c, Paquete p)
        {
            foreach (Paquete item in c.paquetes)
            {
                if (item == p)
                {
                    throw new TrackingIDRepetidoException("El Tracking ID " + p.TrackingID + " Ya Figura En La Lista De Envios.");
                }
            }

            c.paquetes.Add(p);
            Thread nuevoHilo = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(nuevoHilo);
            nuevoHilo.Start();

            return c;
        }


        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            StringBuilder sb = new StringBuilder();

            if (elementos.GetType() == typeof(Correo))
            {
                foreach (Paquete item in ((Correo)elementos).paquetes)
                {
                    sb.AppendFormat("{0} para {1} ({2})", item.TrackingID, item.DireccionEntrega, item.Estado);
                }
            }

            return sb.ToString();

        }

        #endregion


    }
}
