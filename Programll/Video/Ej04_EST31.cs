using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Programll.Video
{
    public class Ej04_EST31
    {
        public static void Main(string[] args)
        {
            int opcion;

            const string Opcion1 = "1. Ver Registro de incidentes de seguridad";
            const string Opcion2 = "2. Ver la meta del periodo";
            const string Opcion3 = "3. Ver el rango valido de intentos de intrusion detectados";
            const string Opcion4 = "4. Salir";
            const string MensajeError = "Opción inválida";
            const string MensajeSalida = "Saliendo del programa";

            do
            {
                Console.WriteLine("======================================================================");
                Console.WriteLine("Menu de consultas de la Agencia de Gobierno Electronico y TIC(AGETIC)");
                Console.WriteLine("======================================================================");
                Console.WriteLine(Opcion1);
                Console.WriteLine(Opcion2);
                Console.WriteLine(Opcion3);
                Console.WriteLine(Opcion4);
                Console.WriteLine();
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Registro de Incidentes de seguridad");
                    Console.WriteLine("");
                    Console.WriteLine("1. 08/10/2007");
                    Console.WriteLine("2. 20/02/2007");
                    Console.WriteLine("");
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Meta de de periodo");
                    Console.WriteLine("");
                    Console.WriteLine("-");
                    Console.WriteLine("-");
                    Console.WriteLine("-");
                    Console.WriteLine("");
                }

                else if (opcion == 3)
                {
                    Console.WriteLine("Rango valido de intentos de intrusion detectados");
                    Console.WriteLine("");
                    Console.WriteLine("-");
                    Console.WriteLine("-");
                    Console.WriteLine("-");
                    Console.WriteLine("");
                }
                else
                    Console.WriteLine(MensajeError);
            }
            while (opcion != 4);
            {
                Console.WriteLine(MensajeSalida);
            }
        }
    }
}