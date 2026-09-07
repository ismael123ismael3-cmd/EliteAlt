using System;
using System.Collections.Generic;
using System.Text;

namespace Programll._20EJERCICIOS
{
    public class EJ06_EST16
    {
        public static void Main(string[] args)
        {
            const int RESERVA_INICIAL = 600;
            const int ENTREGA_DIARIA = 80; 

            const double UMBRAL_ALERTA = RESERVA_INICIAL * 0.20;

            int ReservaActual = RESERVA_INICIAL;
            int jornadas = 0;

            Console.WriteLine("==== CONTROL DE RESERVA DE TIEMPO - AGETIC ====");
            Console.WriteLine("Reserva inicial: " + RESERVA_INICIAL + "minutos");
            Console.WriteLine("Entrega fija por jornada: " + ENTREGA_DIARIA + "minutos");

            while (ReservaActual > 0)
            {
                jornadas++;

                if (ReservaActual >= ENTREGA_DIARIA)
                {
                    ReservaActual -= ENTREGA_DIARIA;
                }
                else
                {
                    ReservaActual = 0;
                }


                Console.WriteLine("Jornada " + jornadas + "Se entregaron minutos. Reserva restante: " + ReservaActual + "min.");

                if (ReservaActual < UMBRAL_ALERTA && ReservaActual > 0)
                {
                    Console.WriteLine("===> ALERTA: La reserva ha bajado del 20% " + UMBRAL_ALERTA + "min.");
                }

            }
             
            Console.WriteLine("==================================================");
            Console.WriteLine("La resrva se ha agotado por completo. ");
            Console.WriteLine("Total de jornadas cubiertas: " + jornadas + "dias.");




        }
    }
    
}
