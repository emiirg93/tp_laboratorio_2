using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MainCorreo
{
    public partial class Form1 : Form
    {
        Correo correo;

        public Form1()
        {
            InitializeComponent();
            this.correo = new Correo();
        }

        private void ActualizarEstados()
        {
            // limpio los listados de estado de los paquetes
            this.lstEstadoIngresado.Items.Clear();
            this.lstEstadoEnViaje.Items.Clear();
            this.lstEstadoEntregado.Items.Clear();



            // Vuelvo a agregar cada paquete al listado correspondiente segun su estado
            foreach (Paquete p in this.correo.Paquetes)
            {
                switch (p.Estado)
                {
                    case EEstado.Ingresado:
                        this.lstEstadoIngresado.Items.Add(p);
                        break;
                    case EEstado.EnViaje:
                        this.lstEstadoEnViaje.Items.Add(p);
                        break;
                    case EEstado.Entregado:
                        this.lstEstadoEntregado.Items.Add(p);
                        break;


                    default:
                        break;
                }
            }
        }

        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (sender is Exception)
            {
                MessageBox.Show(((Exception)sender).Message, "Error con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados();  
            }
            
                
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paquete p = new Paquete(this.txtDireccion.Text,this.mtxtTrackingID.Text);

            p.InformarEstado += paq_InformaEstado; 

            try
            {
                this.correo += p;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Paquete repetido", MessageBoxButtons.OK, MessageBoxIcon.Question); 
            }

            this.ActualizarEstados();
        }

        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (elemento != null)
            {
                string datosElemento = elemento.MostrarDatos(elemento);
                // Muestro los datos del elemento por pantalla
                this.rtbMostrar.Text = datosElemento;

                // Guardo los datos del elemento en un archivo
                datosElemento.Guardar("Salida.txt");
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

    }
}
