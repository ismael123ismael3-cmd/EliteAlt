using System;
using System.Collections.Generic;
using System.Text;

namespace Programll._20EJERCICIOS
{
    public class EJ14_EST16
    {
        public static void Main(string[] args)
        {
            const int TOTAL_ZONAS = 3;
            const int TOTAL_DIAS = 5;
            const int UMBRAL_ALTO = 180;

            int totalGeneralCochabamba = 0;
            Console.WriteLine("===RESTRO DE MEMORIA ORAL - LA GUERRA DEL AGUA (COCHABAMBA)===");
            Console.WriteLine("Procesando " + TOTAL_ZONAS + "zonas durante " + TOTAL_DIAS + "dias.. ");

            for ( int zona = 1; zona <= TOTAL_ZONAS; zona++)
            {
                int subtotalZona = 0;
                Console.WriteLine("--- REGISTRO ZONA" + zona+ "---");

                for (int dia = 1;  dia <= TOTAL_DIAS; dia++)
                {
                    Console.WriteLine("Ingrese los testimonios registrados en el DIA " + dia + ": ");
                    int testimonios = Convert.ToInt32(Console.ReadLine());

                    subtotalZona += testimonios;
                }
                string clasificacion;
                if(subtotalZona > UMBRAL_ALTO)
                {
                    clasificacion = "RESGISTRO ALTO";
                }
                else
                {
                    clasificacion = "REGISTRO BAJO";
                }
                Console.WriteLine("---> Subtotal Zona " + zona + ": " + subtotalZona + "testimonios [" + clasificacion + "]");
                totalGeneralCochabamba += subtotalZona;

            }
             Console.WriteLine("=======================================");
            Console.WriteLine("===REPORTE GENERAL DE COCHABAMBA===");
            Console.WriteLine("Total general de testimonios registrados: " + totalGeneralCochabamba);



        }
    }
}
