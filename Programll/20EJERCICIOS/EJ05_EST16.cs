using System;
using System.Collections.Generic;
using System.Text;

namespace Programll._20EJERCICIOS
{
    public class EJ05_EST16
    {
        public static void Main(string[] args)
        {
            const int TOTAL_CURSOS = 9;
            const int UMBRAL_ESTUDIANTES = 70;

            int cumplieron = 0;
            int noCumplieron = 0;

            for (int i = 1; i <= TOTAL_CURSOS; i++)
            {
                Console.WriteLine("Ingrese la cantidad de estudiantes incritos en el curso " + i + ": ");
                int estudiantes = Convert.ToInt32(Console.ReadLine());

            if (estudiantes >= UMBRAL_ESTUDIANTES)
                {
                    Console.WriteLine("=== Cumple el Umbral ===");
                    cumplieron++;
                }
                else
                {
                    Console.WriteLine("=== No Cumple el Umbral ===");
                    noCumplieron++;
                }

            }

            Console.WriteLine("=== RESUMEN GENERAL DE INCRIPCIONES===");
            Console.WriteLine("Cursos que CUMPLEN el umbral" + cumplieron);
            Console.WriteLine("Cursos que NO CUMPLIERON el umbral" + noCumplieron);
            Console.WriteLine("Total de cursos evaluados: " + (cumplieron + noCumplieron));




        }
    }
}
