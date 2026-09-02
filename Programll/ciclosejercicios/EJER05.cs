using System;
using System.Collections.Generic;
using System.Text;

namespace Programll.ciclosejercicios
{
    public class EJER05
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 3)
                {
                    continue;     
                }

                if (i == 7)
                {
                    break;       
                }

                Console.Write(i + " ");
            }




        }
    }
}
