using System;
using System.Collections.Generic;
using System.Text;

namespace Programll.Video
{
    public class Ej01_EST31
    {
        public static void Main(string[] args) 
        {
            double primerParcial;
            double segundoParcial;
            double tercerParcial;

            Console.WriteLine("Nota del Primer Parcial: ");
            primerParcial = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota del Segundo Parcial: ");
            segundoParcial = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota del Tercer Parcial: ");
            tercerParcial = double.Parse(Console.ReadLine());

            primerParcial = primerParcial * 0.35;
            segundoParcial = primerParcial * 0.35;
            tercerParcial = primerParcial * 0.30;


            double PromedioAponderado = primerParcial + segundoParcial + tercerParcial;
            Console.WriteLine("Primedio Aponderado:" + PromedioAponderado);
        }
    }
}
