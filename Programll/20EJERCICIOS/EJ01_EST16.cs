using System;
using System.Collections.Generic;
using System.Text;

namespace Programll._20EJERCICIOS
{
    public class EJ01_EST16
    {
        public static void Main(string[] args)
        {
            const int TOTAL_UNIDADES = 7;
            string[] unidades = {
                "Javillo",
                "Julio Gutierrez Fe y Alegria",
                "San Silvestre",
                "Abelardo Cumandillo",
                "Enrique Iyambae",
                "Juan Felix Arandio",
                "Inocencio Cespedes",
            };

            int i = 0;

            while (i < TOTAL_UNIDADES)
            {
                Console.WriteLine("Uniadad Educativa Nro. " + (i + 1) + ": " + unidades[i]);
                i++;
            }

            Console.WriteLine("Total de unidades educativas registradas: " + TOTAL_UNIDADES);


        
        }
    }
}
