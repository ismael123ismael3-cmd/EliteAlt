using System;
using System.Collections.Generic;
using System.Text;

namespace Programll.Video
{
    public class Codigo1
    {
        public static void Main(string[] args) 
        {
            const int tramitesTotales = 4;
            int contador = 0;

            while (contador < tramitesTotales)
            {
                Console.WriteLine("Tramite numero " + (contador + 1));
                contador++;
            }

            Console.WriteLine("Total procesado: " + tramitesTotales);
        }
    }
}
