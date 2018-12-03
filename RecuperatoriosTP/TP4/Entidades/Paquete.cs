using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Enumerado que permite indicar el estado del paquete.
    /// </summary>
    

    public class Paquete : IMostrar<Paquete>
    {

        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }

        #region Atributos.

        string direccionEntrega;
        EEstado estado;
        string trackingID;

        #endregion

        #region Propiedades.

        public string DireccionEntrega
        {
            get { return this.direccionEntrega; }
            set { this.direccionEntrega = value; }
        }

        public EEstado Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }

        public string TrackingID
        {
            get { return this.trackingID; }
            set { this.trackingID = value; }
        }

        #endregion

        #region Delegados.

        public delegate void DelegadoEstado(object o, EventArgs e);

        public event DelegadoEstado InformarEstado;

        #endregion

        #region Metodos Y Constructores.

        public Paquete(string direccionEntrega, string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingID;
            this.estado = EEstado.Ingresado;
        }

        public void MockCicloDeVida()
        {


            while (this.Estado != EEstado.Entregado)
            {
                try
                {
                    // Espera 4 segundos entre estados
                    Thread.Sleep(4000);
                }
                catch (Exception)
                {

                }


                switch (this.Estado)
                {
                    case EEstado.Ingresado:
                        this.Estado = EEstado.EnViaje;
                        this.InformarEstado(this, new EventArgs());
                        break;
                    case EEstado.EnViaje:
                        this.Estado = EEstado.Entregado;
                        this.InformarEstado(this, new EventArgs());
                        break;
                    default:
                        break;
                }
            }
            // Al entregar el paquete se inserta en la base de datos.
            try
            {
                PaqueteDAO.Insertar(this);
            }
            catch (Exception e)
            {
                this.InformarEstado(e, new EventArgs());
            }

        }

        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete p = (Paquete)elemento;
            return string.Format("{0} para {1}", p.TrackingID, p.DireccionEntrega);
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            bool tof = false;

            if (p1.TrackingID == p2.TrackingID)
            {
                tof = true;
            }

            return tof;
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

        #endregion

        


    }
}
