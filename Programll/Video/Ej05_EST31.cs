using System;
using System.Collections.Generic;
using System.Text;

namespace Programll.Video
{
    public class Ej05_EST31
    {
        public static void Main(string[] args)
        {
            int siCumple = 0;
            int noCumple = 0;
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine("Ingresar la cantidad de documentos digitalizados del documento");
                int cantidad = int.Parse(Console.ReadLine());

                if (cantidad >= 300)
                {
                    Console.WriteLine("Cumple");
                    siCumple++;
                }
                else
                {
                    Console.WriteLine("No Cumple");
                    noCumple++;
                }

                Console.WriteLine();
            }
            Console.WriteLine("*-Resumen Final-*");
            Console.WriteLine("Documentos Que cumplen: " + siCumple);
            Console.WriteLine("Documentos Que No cumplen: " + noCumple);
        }
    }
}
