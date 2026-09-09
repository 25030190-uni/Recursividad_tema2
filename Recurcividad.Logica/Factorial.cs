using System;
using System.Collections.Generic;
using System.Text;

namespace Recurcividad.Logica
{
    public class Factorial
    {
        public int MiFactorial(int numero)
        {
            // Caso base
            if (numero == 1) 
            {
                return 1;
            }


            // Caso general
                return numero =numero *MiFactorial(numero - 1);
        }
    }
}
