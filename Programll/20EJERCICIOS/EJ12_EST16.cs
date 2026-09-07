using System;
using System.Collections.Generic;
using System.Text;

namespace Programll._20EJERCICIOS
{
    public class EJ12_EST16
    {
        public static void Main(string[] args)
        {
            const int TOTAL_DOCUMENTOS = 5;
            const int UMBRAL_ALTO = 240;
            const int UMBRAL_MEDIO = 100;

            int altaConfirmado = 0;
            int altaPendiente = 0;
            int catalogacionMedia = 0;
            int catalogacionBaja = 0;

            Console.WriteLine("====SISTEMA DE CATALOGACION - CAUSA MARITIMA (MINISTERIO DE RREE====");
            Console.WriteLine("Procesando " + TOTAL_DOCUMENTOS + "documento historicos");

            for (int i = 1; i <= TOTAL_DOCUMENTOS; i++)
            {
                Console.WriteLine("Ingrese la cantidad de documentos catalogados para el registro " + i + ": ");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                if (cantidad >= UMBRAL_ALTO)
                {
                    Console.WriteLine("---> El valor es alto. ¿Fue verificado en campo? (1 = SI, 2 = NO): ");
                    Console.WriteLine(" Opcion: ");
                    int verificado = Convert.ToInt32(Console.ReadLine());

                    if (verificado == 1)
                    {
                        Console.WriteLine("--> Estado: CATALOGACION ALTA CONFIRMADO");
                        altaConfirmado++;
                    }
                    else
                    {
                        Console.WriteLine("---> Estado: CATALOGACION ALTA PENDIENTE DE VERIFICACION");
                        altaPendiente++;
                    }
                }
                else if (cantidad >= UMBRAL_MEDIO)
                {
                    Console.WriteLine("---> Estado: CATALOGACION MEDIA");
                    catalogacionMedia++;
                }
                else
                {
                    Console.WriteLine("---> Estado: CATALOGACION BAJA");
                    catalogacionBaja++;
                }

                Console.WriteLine("==========================================");
                Console.WriteLine("===RESUMEN DE CATALOGACION DE LA CAUSA MARITIMA ===");
                Console.WriteLine("Catalogacion Alta CONFIRMADO:" + altaConfirmado);
                Console.WriteLine("Catalogacion Alta PENDIENTE DE VERIFICACION: " + altaPendiente);
                Console.WriteLine("Catalogacion MEDIA: " + catalogacionMedia);
                Console.WriteLine("Catalogacion BAJA: " + catalogacionBaja);
                Console.WriteLine("Total de resgistros evaluados: " + altaConfirmado + altaPendiente + catalogacionMedia + catalogacionBaja);
            }

        }
    
    }
  
}
