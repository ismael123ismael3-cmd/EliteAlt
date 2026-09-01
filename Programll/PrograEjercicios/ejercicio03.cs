using System;
using System.Collections.Generic;
using System.Text;

namespace Programll.PrograEjercicios
{
    public class ejercicio03
    {
        static void Main(string[] args)
        {
            char respuesta;

            do
            {
                Console.Clear();
                Console.WriteLine("--- CALCULADORA ---");

                Console.Write("Ingresa el primer número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa un operador (+, -, *, /): ");
                char op = Console.ReadLine()[0];

                Console.Write("Ingresa el segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (op)
                {
                    case '+':
                        Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
                        break;

                    case '-':
                        Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
                        break;

                    case '*':
                        Console.WriteLine($"Resultado: {num1} * {num2} = {num1 * num2}");
                        break;

                    case '/':
                       
                        if (num2 != 0)
                        {
                            Console.WriteLine($"Resultado: {num1} / {num2} = {num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir entre cero.");
                        }
                        break;

                    default:
                        Console.WriteLine("Error: Operador no válido.");
                        break;
                }

                // Preguntar si desea hacer otra operación
                Console.Write("¿Deseas realizar otro cálculo? (s/n): ");
                respuesta = Console.ReadLine().ToLower()[0];

            } while (respuesta == 's');

            Console.WriteLine("¡Gracias por usar la calculadora!");





        }

    }
}
