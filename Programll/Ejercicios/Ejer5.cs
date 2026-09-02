using System;
using System.Collections.Generic;
using System.Text;

namespace Programll.Ejercicios
{
    public class Ejer5
    {
        public static void Main(string[] args)
        {
            for (int tabla = 1; tabla <= 3; tabla++)
            {
                Console.WriteLine("--- Tabla del " + tabla + " ---");

                for (int n = 1; n <= 5; n++)
                {
                    Console.WriteLine(tabla + " x " + n + " = " + (tabla * n));
                }
            }
        }
    }
}
