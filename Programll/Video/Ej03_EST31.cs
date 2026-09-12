using System;
using System.Collections.Generic;
using System.Text;

namespace Programll.Video
{
    public class Ej03_EST31
    {
        public static void Main(string[] args)
        {
            const double MIN_KWH = 0.0;
            const double MAX_KWH = 900.0;

            double kwhGenerados;
            do
            {
                Console.Write($"Ingrese los kWh generados en el mes ({MIN_KWH} a {MAX_KWH}): ");
                kwhGenerados = double.Parse(Console.ReadLine());
                if (kwhGenerados < MIN_KWH || kwhGenerados > MAX_KWH)
                {
                    Console.WriteLine($"Error: El dato ingresado está fuera del rango permitido ({MIN_KWH} a {MAX_KWH} kWh). Intente de nuevo.\n");
                }

            } while (kwhGenerados < MIN_KWH || kwhGenerados > MAX_KWH); // Se repite mientras esté fuera del rango

            Console.WriteLine("\n¡Dato registrado correctamente! kWh generados: " + kwhGenerados);

        }
    }
}
