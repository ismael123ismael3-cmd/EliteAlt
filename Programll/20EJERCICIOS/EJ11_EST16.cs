using System;
using System.Collections.Generic;
using System.Text;

namespace Programll._20EJERCICIOS
{
    public class EJ11_EST16
    {
        public static void Main(string[] args)
        {
            const int OPCION_REGISTRAR = 1;
            const int OPCION_CONSULTAR = 2;
            const int OPCION_SALIR = 3;

            int regristroUrgentes = 0;
            int opcionPrincipal;

            do
            {
                Console.WriteLine("====SITEMA DE GESTION ABNB - PARTES DE GRERRA (JUANA AZURDUY====");
                Console.WriteLine("1) Registrar parte de guerra");
                Console.WriteLine("2) Consultar meta del periodo");
                Console.WriteLine("3) Salir");
                Console.WriteLine("Selecciona una opcion: ");
                opcionPrincipal = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");



                if (opcionPrincipal == OPCION_REGISTRAR)
                {
                    Console.WriteLine(">====REGISTRO DE PARTE DE GUERRA===<");
                    Console.WriteLine("Seleccione la zona de origen");
                    Console.WriteLine("1) Zona Norte");
                    Console.WriteLine("2) Zona Sur");
                    Console.WriteLine("Opcion de zona");
                    int zona = Convert.ToInt32(Console.ReadLine());

                    if (zona == 1 || zona == 2)
                    {
                        string nombreZona = (zona == 1) ? "Zona Norte" : "Zona Sur";

                        Console.WriteLine("¿El regritro es urgente?");
                        Console.WriteLine("1) Si");
                        Console.WriteLine("2) No");
                        Console.WriteLine("Opcion de urgencia: ");
                        int urgencia = Convert.ToInt32(Console.ReadLine());

                        if (urgencia == 1)
                        {
                            regristroUrgentes++;
                            Console.WriteLine("-->[URGENTE] Parte de guerra registrado prioritariamente para la " + nombreZona + "..");
                        }
                        else if (urgencia == 2)
                        {
                            Console.WriteLine("---> [NORMAL] Parte de guerra registrado en cola estandar para la " + nombreZona + "..");

                        }
                        else
                        {
                            Console.WriteLine("--> Opcion de urgencia no valida. Se cancela el riesgo actual");
                        }

                    }
                    else
                    {
                        Console.WriteLine("---> Zona ingresada no es valida. Se calcela el registro actual");
                    }

                }
                else if (opcionPrincipal == OPCION_CONSULTAR)
                {
                    Console.WriteLine("===META DEL PERIODO===");
                    Console.WriteLine("Meta actual ABNB: Catalogacion y digitalizacion de 150 partes de guerra");
                }

                else if (opcionPrincipal == OPCION_CONSULTAR)
                {
                    Console.WriteLine("Saliendo del sistema");
                }
                else
                {
                    Console.WriteLine("Error: La opcion ingresada no existe. Intente de nuevo");
                }

            } while (opcionPrincipal  != OPCION_CONSULTAR);

            Console.WriteLine("================================");
            Console.WriteLine("Sesion finalizada. ");
            Console.WriteLine("Total de partes de guerra URGENTES registrados: " + regristroUrgentes);
        }
    }
}
