using System;
using System.Collections.Generic;
using System.Text;

namespace Programll.Ejercicios
{
    public class Ejer1
    {
        static void Main(string[] args)

        {
            int vidas = 0;

            while (vidas > 0)     // 0 > 0 es FALSO desde el inicio
            {
                Console.WriteLine("Te queda una vida");   // nunca se imprime
                vidas--;
            }
    }
}
