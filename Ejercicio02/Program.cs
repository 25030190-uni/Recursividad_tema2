using System;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos números enteros positivos desea ingresar?: ");
            int cantidad = int.Parse(Console.ReadLine());

            int mayorNumero = 0;
            int mayorSuma = -1;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Ingrese el entero positivo #{i}: ");
                int num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    int sumaActual = SumaDigitos(num);
                    Console.WriteLine($" -> Suma de dígitos de {num}: {sumaActual}");

                    if (sumaActual > mayorSuma)
                    {
                        mayorSuma = sumaActual;
                        mayorNumero = num;
                    }
                }
                else
                {
                    Console.WriteLine(" El número ingresado no es positivo. Se ignora.");
                }
            }

            if (mayorSuma != -1)
            {
                Console.WriteLine($"El entero cuya suma de dígitos es mayor es: {mayorNumero}");
                Console.WriteLine($"Suma total de sus dígitos: {mayorSuma}");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

      
        public static int SumaDigitos(int n)
        {
            if (n < 10)
            {
                return n;
            }

            return (n % 10) + SumaDigitos(n / 10);
        }
    }
}