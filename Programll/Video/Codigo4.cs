using System;
using System.Collections.Generic;
using System.Text;

namespace Programll.Video
{
    public class Codigo4
    {
        public static void Main(string[] args)
        {
            const string TITULO_MENU = "=== MENÚ DE CONSULTAS AGETIC ===";
            const string OPCION_1 = "1. Ver el registro de incidentes de seguridad";
            const string OPCION_2 = "2. Ver la meta del periodo";
            const string OPCION_3 = "3. Ver el rango valido de intentos de intrusion detectados";
            const string OPCION_4 = "4. Salir";

            const int OPCION_SALIDA = 4;
            int opcionSeleccionada;

            do
            {
                Console.WriteLine(TITULO_MENU);
                Console.WriteLine(OPCION_1);
                Console.WriteLine(OPCION_2);
                Console.WriteLine(OPCION_3);
                Console.WriteLine(OPCION_4);
                Console.Write("Seleccione una opción: ");

                opcionSeleccionada = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (opcionSeleccionada == 1)
                {
                    Console.WriteLine("--> Mostrando el registro de incidentes de seguridad...\n");
                }
                else if (opcionSeleccionada == 2)
                {
                    Console.WriteLine("--> La meta del periodo es: 3000 toneladas / trámites procesados.\n");
                }
                else if (opcionSeleccionada == 3)
                {
                    Console.WriteLine("--> El rango válido de intentos permitidos es: 0 a 900.\n");
                }
                else if (opcionSeleccionada == OPCION_SALIDA)
                {
                    Console.WriteLine("--> Saliendo del sistema de AGETIC. ¡Hasta luego!");
                }
                // Requisito obligatorio: El else final atiende las opciones inválidas
                else
                {
                    Console.WriteLine("--> Error: La opción no existe. Intente nuevamente.\n");
                }

            } while (opcionSeleccionada != OPCION_SALIDA);
        }
    }
}
    }
}

            
    

