using System;
using System.Collections.Generic;
using System.Text;

namespace Programll.Video
{
    public class Ej01_EST31
    {
        public static void Main(string[] args) 
        {
            const double primerParcial = 0 % 0.30;
            const double segundoParcial = 0 % 0.30;
            const double tercerParcial = 0 % 0.30;

            Console.WriteLine("Nota del Primer Parcial: ");
            primerParcial = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota del Segundo Parcial: ");
            segundoParcial = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota del Tercer Parcial: ");
            tercerParcial = double.Parse(Console.ReadLine());

            double PromedioAponderado = primerParcial + segundoParcial + tercerParcial;
            Console.WriteLine("Primedio Aponderado:" + PromedioAponderado);
        }
    }
}
