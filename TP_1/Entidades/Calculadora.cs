using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        #region Metodos

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double operacionRealizada = 0;

            operador = ValidarOperador(operador);

            switch (operador)
            {
                case "*":
                    operacionRealizada = num1*num2;
                    break;
                case "-":
                    operacionRealizada = num1 - num2;
                    break;
                case "/":
                      operacionRealizada = num1 / num2;
                    break;
                default: 
                    operacionRealizada = num1 + num2;
                    break;
            }

            return operacionRealizada;
            
        }

        public static string ValidarOperador(string operador)
        {
            string retorno = "+";
            
            if (operador == "+" || operador == "-" || operador == "/" || operador == "*")
            {
                retorno = operador;
            }

            return retorno;
        }

        #endregion
    }
}
