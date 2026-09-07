using System;
using System.Collections.Generic;
using System.Text;

namespace Programll._20EJERCICIOS
{
    public class EJ09_EST16
    {
        public static void Main(string[] args)
        {
            const int TOTAL_INCIDENTES = 5;

            int maxIntentos = 0;
            int minIntentos = 0;
            int incidenteMax = 1;
            int incidenteMin = 1;

            Console.WriteLine("====MONITOR DE SEGURIDAD DIGITAL - AGETIC ===");
            Console.WriteLine("Registro y analisis de: " + TOTAL_INCIDENTES + "incidentes de intrusion");


            for (int i = 1; i <= TOTAL_INCIDENTES; i++)
            {
                Console.WriteLine("Ingrese los intentos de intrusion del Incidente " + i + ": ");
                int intentos = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    maxIntentos = intentos;
                    minIntentos = intentos;
                    incidenteMax = i;
                    incidenteMin = i;
                }
                else
                {
                    if (intentos > maxIntentos)
                    {
                        maxIntentos = intentos;
                        incidenteMax = i;
                    }
                    if (intentos < minIntentos)
                    {
                        minIntentos = intentos;
                        incidenteMin = i;
                    }
                }

                Console.WriteLine("========================================");
                Console.WriteLine("REPORTE DE EXTREMOS DE SEGURIDAD");
                Console.WriteLine("Maximo de instrucciones: " + maxIntentos + "(Ocurrio en el Incidnete Nro. " + incidenteMax);
                Console.WriteLine("Minimo de instrucciones: " + minIntentos + "(Ocurrio en el Incidnete Nro. " + incidenteMin);
            }



        }

    }
    
}
