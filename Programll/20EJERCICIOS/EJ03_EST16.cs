using System;
using System.Collections.Generic;
using System.Text;

namespace Programll._20EJERCICIOS
{
    public class EJ03_EST16
    {
        public static void Main(string[] args)
        {
            const int MIN_CONTRATADOS = 0;
            const int MAX_CONTRATDOS = 150;

            int contratados;

            do
            {
                Console.Write("Ingrese la cantidad de postulantes contratados (0 - 150)");

                contratados = Convert.ToInt32(Console.ReadLine());

                if (contratados < MIN_CONTRATADOS || contratados > MAX_CONTRATDOS)
                {
                    Console.WriteLine("Error: El valor debe estar entre " + MIN_CONTRATADOS + " y " + MAX_CONTRATDOS + " Intente de nuevo. ");
                }

            } while (contratados < MIN_CONTRATADOS || contratados > MAX_CONTRATDOS);

            Console.WriteLine("Dato registrado correctamente: " + contratados + "postulantes contratados. ");
           

        }
    }
}
