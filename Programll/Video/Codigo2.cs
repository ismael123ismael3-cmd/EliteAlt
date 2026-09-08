using System;
using System.Collections.Generic;
using System.Text;

namespace Programll.Video
{
    public class Codigo2
    {
        public static void Main(string[] args)
        {
            const double META_TONELADAS = 3000.0;
            const int TOTAL_LOTES = 6;

            int contadorLote = 0;
            double totalAcumulado = 0.0;

            while (contadorLote < TOTAL_LOTES)
            {
                Console.Write($"Ingrese las toneladas producidas del lote {contadorLote + 1}: ");
                double toneladasLote = double.Parse(Console.ReadLine());
                totalAcumulado += toneladasLote;
                contadorLote++;
                Console.WriteLine("\nTotal acumulado de producción: " + totalAcumulado + " toneladas.");
                
            }

            if (totalAcumulado >= META_TONELADAS)
            {
                Console.WriteLine("¡Felicidades! Se alcanzó la meta de " + META_TONELADAS + " toneladas.");
            }
            else
            {
                Console.WriteLine("No se alcanzó la meta. Faltaron " + (META_TONELADAS - totalAcumulado) + " toneladas.");
            }
        }
    }
}
