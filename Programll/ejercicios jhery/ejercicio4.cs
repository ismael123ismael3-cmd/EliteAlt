using System;
using System.Collections.Generic;
using System.Text;

namespace Programll.ejercicios_jhery
{
    internal class ejercicio4
    {
        public static void Main(string[] args)
        {

            // Cuenta regresiva: 10, 9, 8 ... 1
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            // Solo los numeros pares del 2 al 20
            for (int i = 2; i <= 20; i = i + 2)
            {
                Console.Write(i + " ");
            }

            // ACUMULADOR: suma del 1 al 100
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("La suma es: " + suma);   // 5050



        }
    }

}
