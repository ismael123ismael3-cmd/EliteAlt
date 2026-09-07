using System;
using System.Collections.Generic;
using System.Text;

namespace Programll._20EJERCICIOS
{
    public class EJ10_EST16
    {
        public static void Main(string[] args)
        {
            const int TOTAL_DOCUMENTOS = 7;
            const double UMBRAL_ACEPTABLE = 120.0;

            double sumaTotal = 0;
            int i = 1;

            Console.WriteLine("===DIGITALIZACION DE ARCHIVOS HISTORICOS - CASA DE LA LIBERTAD===");
            Console.WriteLine("Registro de " + TOTAL_DOCUMENTOS + "documentos historicos de Sucre");

            while ( i < TOTAL_DOCUMENTOS)
            {
                Console.WriteLine("Ingrese la cantidad de archivos digitalizados del documento" + i + ": ");

                double paginas = Convert.ToDouble(Console.ReadLine());

                sumaTotal += paginas;
                i++;
            }

            double promedio = sumaTotal / TOTAL_DOCUMENTOS;

            Console.WriteLine("=========================================");
            Console.WriteLine("REPORTE FINAL DE DIGITALIZACION");
            Console.WriteLine("Total acumulado de archivos: " + sumaTotal);
            Console.WriteLine("Promedio de digitalizacion: " + promedio.ToString("F2") + "archivo por documento");

            if (promedio >= UMBRAL_ACEPTABLE)
            {
                Console.WriteLine("DIAGNOSTICO: La situacion de Sucre es ACEPTABLE.");

            }
            else
            {
                Console.WriteLine("DIAGNOSTICO: La situacion de Sucre REQUIERE INTERVENCION.");
            }

            
        }
    }
}
