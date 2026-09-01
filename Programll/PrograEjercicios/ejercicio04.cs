using System;
using System.Collections.Generic;
using System.Text;

namespace Programll.PrograEjercicios
{
    public class ejercicio04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- TRADUCCIÓN DE ESCALERA A (usando switch) ---");
            Console.Write("Ingresa un código de estado (ej. 100, 200, 404): ");
            int codigo = Convert.ToInt32(Console.ReadLine());

        
            switch (codigo)
            {
                case 100:
                    Console.WriteLine("Código 100: Continuar");
                    break;
                case 200:
                    Console.WriteLine("Código 200: OK / Éxito");
                    break;
                case 404:
                    Console.WriteLine("Código 404: No encontrado");
                    break;
                default:
                    Console.WriteLine("Código no reconocido / Desconocido");
                    break;
            }

            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("--- EXPLICACIÓN DE LA ESCALERA B ---");

           
            Console.WriteLine(
                "¿Por qué la Escalera B no se puede traducir directamente a un switch tradicional?\n\n" +
                "Respuesta: La Escalera A compara una misma variable contra valores puntuales e independientes (100, 200, 404),\n" +
                "lo cual encaja perfectamente con la estructura 'case'.\n\n" +
                "En cambio, la Escalera B evalúa rangos continuos utilizando operadores relacionales (temperatura > 35).\n" +
                "Dado que 'case' tradicional solo admite constantes fijas y existirían infinitos valores posibles dentro de ese rango,\n" +
                "la mejor opción de diseño sigue siendo la estructura 'if / else if'."
            );

            Console.WriteLine("\nPresiona cualquier tecla para finalizar...");
            Console.ReadKey();





        }
}   }
