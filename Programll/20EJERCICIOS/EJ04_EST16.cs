using System;
using System.Collections.Generic;
using System.Text;

namespace Programll._20EJERCICIOS
{
    public class EJ04_EST16
    {
        public static void Main(string[] args)
        {
            const string TITULO_MENU = "====MENU DE CONSULTA - COOPERATIVA DE RECICLADORES ===";

            const string OPCION_1 = "1) Ver el registro de barrios";
            const string OPCION_2 = "2) Ver la meta del periodo";
            const string OPCION_3 = "3) Ver el rango valido de kilogramos de material reciclable acopiados";
            const string OPCION_4 = "4) Salir";
            const string MENSAJE_ERROR = "Error: La opcion ingresada no existe. Intente de nuevo";

            const int OPCION_SALIR = 4;

            int opcion;

            do
            {
                Console.WriteLine(TITULO_MENU);
                Console.WriteLine(OPCION_1);
                Console.WriteLine(OPCION_2);
                Console.WriteLine(OPCION_3);
                Console.WriteLine(OPCION_4);
                Console.Write("Seleccione una opcion: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                if (opcion == 1)
                {
                    Console.WriteLine("== Regritro de Barrios ==");
                    Console.WriteLine("Barrios registrados: Zona central, Barrio Norte, Villa Fatima");

                }
                else if (opcion == 2)
                {

                    Console.WriteLine("=== Meta del periodo ===");
                    Console.WriteLine("Meta actual: 5,000 Kg de material reciclable");
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("=== Rango Valido de Acopio ===");
                    Console.WriteLine("Rango permitido: de 10Kg a 1,000 Kg por resoleccion ");
                }
                else if (opcion == OPCION_SALIR)
                {

                    Console.WriteLine(" Saliendo del programa...");

                }
                else
                {
                    Console.WriteLine(MENSAJE_ERROR + "...");
                }

            } while (opcion != OPCION_SALIR);




        }
    }
}
