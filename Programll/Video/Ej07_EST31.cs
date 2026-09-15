using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace Programll.Video
{
    public class Ej07_EST31
    {
        public static void Main(string[] args)
        {
            const int CatAlt = 240;
            const int CatMed = 100;

            int alta;
            int media;
            int baja;


            for (int i = 1; i<= 4; i ++)
            {
                Console.WriteLine("Ingresa cantidad de documentos catalogados");
                int valor = int.Parse(Console.ReadLine());

                if (valor >= CatAlt)
                {
                    Console.WriteLine("Resultado: Categoria Alta");
                    alta ++;
                }
                else if (valor >= CatMed)
                {
                    Console.WriteLine("Resultado: Categoria Media");
                    media ++;
                }
                else
                {
                    Console.WriteLine("Resultado: Categoria Baja");
                    baja ++;
                }
                Console.WriteLine("Resultados");
                Console.WriteLine("Categoria Alta:" + alta);
                Console.WriteLine("Categoria Media" + media);
                Console.WriteLine("Categoria Media" + baja);


            }


        }
    }
}
