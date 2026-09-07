using System;
using System.Collections.Generic;
using System.Text;

namespace Programll._20EJERCICIOS
{
    public class EJ07_EST16
    {
        public static void Main(string[] args)
        {
            const int TOTAL_LOTES = 7;
            const double UMBRAL_ALTO = 300.0;
            const double UMBRAL_MEDIO = 120.0;

            int produccionAlta = 0;
            int produccionMedia = 0;
            int produccionBaja = 0;

            Console.WriteLine("=== SEMAFORO DE CONTROL DE PRODUCCION - YLB ====");
            Console.WriteLine("Procesando " + TOTAL_LOTES + "lotes de carbonato de litio...");

            for (int i = 1;  i <= TOTAL_LOTES; i++)
            {
                Console.WriteLine("Ingese las toneladas producidas en el lote " + i + ": ");
                double toneladas = Convert.ToDouble (Console.ReadLine());

                if (toneladas >= UMBRAL_ALTO)
                {
                    Console.WriteLine("Categoria: PRODUCCION ALTA");
                    produccionAlta++;
                }
                else if (toneladas >= UMBRAL_MEDIO)
                {
                    Console.WriteLine("Categoria: PRODUCCION MEDIA");
                    produccionMedia++;
                }
                else
                {
                    Console.WriteLine("Categoria. PRODUCCION BAJA");
                    produccionBaja++;

                }

                Console.WriteLine("===============================");
                Console.WriteLine("===RESUMEN DE CONTROL DE CALIDAD YLB ===");
                Console.WriteLine("Lotes con PRODUCCION ALTA (>=" + UMBRAL_ALTO + " t): " + produccionAlta);
                Console.WriteLine("Lotes con PRODUCCION MEDIA (>=" + UMBRAL_MEDIO + " t): " + produccionMedia);
                Console.WriteLine("Lotes con PRODUCCION BAJA (>=" + UMBRAL_MEDIO + " t): " + produccionBaja);
                Console.WriteLine("TOTAL DE LOTES EVALUADOS: " + (produccionAlta + produccionMedia + produccionBaja));


            }


        }
    }
}
