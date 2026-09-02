using System;
using System.Collections.Generic;
using System.Text;

namespace Programll.ejercicios_jhery
{
    internal class ejercicio3
    {
        public static void Main(string[] args)
        {
            int edad;

            do
            {
                Console.Write("Ingrese su edad (1 a 120): ");
                edad = int.Parse(Console.ReadLine());

                if (edad < 1 || edad > 120)
                {
                    Console.WriteLine("Edad invalida. Intente de nuevo.");
                }
            }
            while (edad < 1 || edad > 120);

            Console.WriteLine("Edad registrada: " + edad);


        }
    }

}

