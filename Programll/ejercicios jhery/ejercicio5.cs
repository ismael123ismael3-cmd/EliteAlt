using System;
using System.Collections.Generic;
using System.Text;

namespace Programll.ejercicios_jhery
{
    internal class ejercicio5
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 3)
                {
                    continue;      // no imprime el 3, pero el ciclo sigue
                }

                if (i == 7)
                {
                    break;         // corta el ciclo: el 7 y los siguientes no salen
                }

                Console.Write(i + " ");
            }



        }
    }

}
