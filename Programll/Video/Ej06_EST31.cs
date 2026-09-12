using System;
using System.Collections.Generic;
using System.Text;

namespace Programll.Video
{
    public class Ej06_EST31
    {
        public static void Main(string[] args)
        {
            double reserva = 1800;
            int jornada = 0;


            while (reserva > 0)
            {
                jornada++;
                reserva -= 360;

                Console.WriteLine($"Jornada: " + jornada + " Quedan: " + reserva + "documentos.");
                
                if (reserva == 360)
                {
                    Console.WriteLine("Alerta Reserva Baja (20%)");
                }
            }
            Console.WriteLine("Duracion de la reserva: " + jornada + " jornadas");
        }
    }
}
