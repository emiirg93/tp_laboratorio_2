using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos

        private double numero;
        #endregion

        #region Propiedad

        private string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        #endregion

        #region Metodos

        public static string BinarioDecimal(string binario)
        {
            int i;
            int entero = 0;
            string retorno = string.Empty;
            string mensaje = string.Empty;

            if (binario == "Numero Decimal")
            {
                binario = "";
            }
            else
            {
                if (binario != "" && (object)binario != null && binario != "Valor Inválido")
                {

                    foreach (char c in binario)
                        if (c != '0' && c != '1')
                            return "Numero Decimal";

                    for (i = 1; i <= binario.Length; i++)
                    {
                        entero += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);
                    }
                    retorno = entero.ToString();
                }
                else
                {
                    mensaje = "Valor Inválido";
                    retorno = mensaje;
                }
            }

            return retorno;
        }

        public static string DecimalBinario(string numero)
        {
            int conversion;
            string retorno = string.Empty;

                    if (int.TryParse(numero, out conversion))
                    {
                        while (conversion > 0)
                        {
                            retorno = (conversion % 2).ToString() + retorno;
                            conversion = conversion / 2;
                        }
                    }
                    else
                        retorno = "Valor Inválido";

            return retorno;
        }

        public static string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }

        //Constructor.

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            if ((object)n1 != null && (object)n2 != null)
            {
                n1.numero -= n2.numero;
            }

            return n1.numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            if ((object)n1 != null && (object)n2 != null)
            {
                n1.numero *= n2.numero;
            }

            return n1.numero;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            if ((object)n1 != null && (object)n2 != null)
            {
                n1.numero /= n2.numero;
            }

            return n1.numero;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            if ((object)n1 != null && (object)n2 != null)
            {
                n1.numero += n2.numero;
            }

            return n1.numero;
        }

        private static double ValidarNumero(string strNumero)
        {
            double retorno;
            bool verificar = double.TryParse(strNumero, out retorno);

            if (verificar == false)
            {
                retorno = 0;
            }

            return retorno;

        }


        #endregion
    }
}
