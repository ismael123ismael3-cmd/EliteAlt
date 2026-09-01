using System;
using System.Collections.Generic;
using System.Text;

namespace Programll.PrograEjercicios
{
    public class ejercicio02
    {
        public static void Main(string[] args)
        {
            double suma = 0;
            int contador = 0;

            Console.WriteLine("Ingresa un número:");
            Console.WriteLine("Nota: escribe 0 para salir:");
            double numero = Convert.ToDouble(Console.ReadLine());

            while (numero != 0)
            {
                suma += numero;    
                contador++;        

                Console.WriteLine("Ingresa otro número:");
                numero = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("--- RESULTADOS ---");
            Console.WriteLine("Cantidad de números ingresados: " + contador);
            Console.WriteLine("Suma total: " + suma);

           
            if (contador > 0)
            {
                double promedio = suma / contador;
                Console.WriteLine("Promedio: " + promedio);
            }
            else
            {
                Console.WriteLine("No se ingresaron números para calcular el promedio.");
            }

            Console.WriteLine("Presiona cualquier tecla para finalizar...");
            Console.ReadKey();




        }

    
    }
}
