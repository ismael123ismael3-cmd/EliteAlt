using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Programll.PrograEjercicios
{
    public class ejercicio01
    {
        public static void Main(string[] args)
        {
            Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }
            



        }
    }
}
