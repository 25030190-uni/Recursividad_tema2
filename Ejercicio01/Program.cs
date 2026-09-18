using System;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Ingrese una cadena de texto: ");
            string texto = Console.ReadLine();

            int total = Vocales(texto);
            Console.WriteLine($"Número total de vocales: {total}");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        public static int Vocales(string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
            {
                return 0;
            }

            char primerCar = char.ToLower(cadena[0]);

            int esVocal = (primerCar == 'a' || primerCar == 'e' || primerCar == 'i'
                           || primerCar == 'o' || primerCar == 'u') ? 1 : 0;

            return esVocal + Vocales(cadena.Substring(1));
        }
    }
}