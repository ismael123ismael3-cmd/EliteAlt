using System;
using System.Collections.Generic;
using System.Text;

namespace Programll._20EJERCICIOS
{
    public class EJ13_EST16
    {
        public static void Main(string[] args)
        {
            const int META_TITULOS = 4000;
            int acumulado = 0;
            int periodos = 0;

            Console.WriteLine("====SIATEMA DE SANEAMIENTO Y TITULACION - INRA===");
            Console.WriteLine("Meta establecida: " + META_TITULOS + "titulos de propiedad ");
            while (acumulado < META_TITULOS)
            {
                periodos++;
                Console.WriteLine("Ingrese la cantidad de titulos emitidos en el Periodo " + periodos + ": ");
                int avance = Convert.ToInt32(Console.ReadLine());

                if (avance == 0)
                {
                    Console.WriteLine("--> ADVERTENCIA: El perido " + periodos + "fue improductivo (0 titulados registrados)");
                }
                else if (avance < 0)
                {

                    Console.WriteLine("---> ACVERTENCIA: Se ingreso un valor negativo. No suma al avance. "); 
                }
                else
                {
                    acumulado += avance;
                }

                int saldoPendiente = META_TITULOS - acumulado;

                if (saldoPendiente <  0)
                {
                    saldoPendiente = 0;
                }
                Console.WriteLine("---> Acumulado actual: " + acumulado + " | Saldo pendiente: " + saldoPendiente + "...");
            }
            int excedente = acumulado - META_TITULOS;

            Console.WriteLine("===================================");
            Console.WriteLine("===META ALCANZADA SATISFACTORIAMENTE===");
            Console.WriteLine("Total de titulos acumulados: " + acumulado);
            Console.WriteLine("Exedente sobre la meta: " + excedente);
            Console.WriteLine("Cantidad de periodos utilizados: " + periodos);
        }
    }
}
