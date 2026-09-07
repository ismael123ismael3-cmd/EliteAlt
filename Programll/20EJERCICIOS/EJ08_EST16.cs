using System;
using System.Collections.Generic;
using System.Text;

namespace Programll._20EJERCICIOS
{
    public class EJ08_EST16
    {
        public static void Main(string[] args)
        {
            const int TOTAL_COMUNIDADES = 9;
            int turnoMañana = 0;
            int turnoTarde = 0;

            int i = 1;
            Console.WriteLine("=== INSPECCION DE SISTEMAS FOTOVOLTAICOS - ENDE ===");
            Console.WriteLine("Organizaion de turno en SAN MATIAS (Santa Cruz)");

            while (i <=  TOTAL_COMUNIDADES)
            {
                Console.WriteLine("Ingrese el numero del sistema fotovoltaico de la comuniadad " + i + ": ");
                int numeroPanel = Convert.ToInt32(Console.ReadLine());

                if (numeroPanel % 2 == 0)
                {
                    Console.WriteLine("---> Panel NRO. " + numeroPanel + ": Inspeccion por la MAÑANA (Par)");
                    turnoMañana++;
                }
                else
                {
                    Console.WriteLine("---> Panel NRO. " + numeroPanel + ": Inspeccion por la TARDE (Impar)");
                    turnoTarde++;
                }
                i++;

            }

            Console.WriteLine("========================================");
            Console.WriteLine("=== RESUMEN GENERAL DE INSPECCIONES ===");
            Console.WriteLine("Comunidades a inpeccionar por la MAÑANA: " + turnoMañana);
            Console.WriteLine("Comunidades a inpeccionar por la TARDE: " + turnoTarde);
            Console.WriteLine("Total de comunidades inspeccionadas: " + (turnoMañana + turnoTarde));

        }
    }
}
