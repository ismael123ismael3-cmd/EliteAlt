using System;
using System.Collections.Generic;
using System.Text;

namespace Programll.Ejercicios
{
    public class Ejer4
    {
        public static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("1. Jugar");
                Console.WriteLine("2. Salir");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());
            }
            while (opcion != 2);
        }
    }
}
