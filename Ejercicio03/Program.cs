using System;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de n (entero positivo): ");
            int n = int.Parse(Console.ReadLine());

            if (n >= 0)
            {
                int resultado = SumaEnteros(n);
                Console.WriteLine($"S({n}) = {resultado}");
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

     
        public static int SumaEnteros(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            return SumaEnteros(n - 1) + n;
        }
    }
}