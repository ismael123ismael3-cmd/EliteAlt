using System;
using System.Collections.Generic;
using System.Text;

namespace Programll._20EJERCICIOS
{
    public class EJ02_EST16
    {
        public static void Main(string[] args)
        {
            const int META = 300;
            const int TOTAL_TALLERES = 9;

            int suma = 0;
            int contador = 1;

            while (contador <= TOTAL_TALLERES)
            {
                Console.Write($"Ingrese la cantidad de aprobados del taller {contador}");

                int aprovados = int.Parse(Console.ReadLine());

                suma += aprovados;
                contador++;

            }

            Console.WriteLine($"Total acumulado de particiántes aprobados: {suma}");

            if (suma >= META)
            {
                Console.WriteLine("SE ALCANZO LA META DE PARTICIPANTES:");
            }
            else
            {
                Console.WriteLine($"No se alcanzo la meta. Faltaron {META - suma} participantes");
            }

        }
    }
}
