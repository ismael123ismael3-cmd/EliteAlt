using System;
using System.Collections.Generic;
using System.Text;

namespace Programll.Ejercicios
{
    public class Ejer2
    {
        public static void Main(string[] args)
        {
            int contador = 1;
            while (contador <= 5)
            {
                Console.WriteLine("Vuelta numero " + contador);
                contador++;
            }
            Console.WriteLine("El ciclo termino.");
        }
    }
}
