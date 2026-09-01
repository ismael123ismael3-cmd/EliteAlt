using System;
using System.Collections.Generic;
using System.Text;

namespace Programll.PrograEjercicios
{
    public class ejercicio05
    {
        public static void Main(string[] args)
        {
            int opcion;
            int totalPedidos = 0;

            do
            {
                Console.WriteLine("\n=== MENÚ DE PEDIDOS ===");
                Console.WriteLine("1. Pedir Hamburguesa");
                Console.WriteLine("2. Pedir Pizza");
                Console.WriteLine("3. Pedir Tacos");
                Console.WriteLine("4. Pedir Bebida");
                Console.WriteLine("5. Ver reporte");
                Console.WriteLine("6. Salir");
                Console.Write("Selecciona una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion >= 1 && opcion <= 4)
                {
                    int cantidad;
                    // Validación con do-while para garantizar cantidad > 0
                    do
                    {
                        Console.Write("Ingresa la cantidad (debe ser mayor a 0): ");
                        cantidad = Convert.ToInt32(Console.ReadLine());

                        if (cantidad <= 0)
                        {
                            Console.WriteLine(" Error: La cantidad debe ser mayor a 0.");
                        }
                    } while (cantidad <= 0);

                    totalPedidos += cantidad;
                    Console.WriteLine($" ¡Se agregaron {cantidad} producto(s) al pedido!");
                }
                else if (opcion == 5)
                {
                    Console.WriteLine();
                    // Dimensiones del recuadro
                    int filas = 5;
                    int columnas = 35;

                    // For anidado para imprimir el recuadro de asteriscos
                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            // Imprimir asteriscos en los bordes
                            if (i == 0 || i == filas - 1 || j == 0 || j == columnas - 1)
                            {
                                Console.Write("*");
                            }
                            else if (i == 2 && j == 4) // Imprimir texto dentro del marco
                            {
                                string texto = $"Pedidos acumulados: {totalPedidos}";
                                Console.Write(texto);
                                j += texto.Length - 1; // Salta los espacios ocupados por el texto
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else if (opcion != 6)
                {
                    Console.WriteLine(" Opción inválida. Intenta nuevamente.");
                }

            } while (opcion != 6);

            Console.WriteLine("\n¡Gracias por usar el sistema!");





        }

    }
}
