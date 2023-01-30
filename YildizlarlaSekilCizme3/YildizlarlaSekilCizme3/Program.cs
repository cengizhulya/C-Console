using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YildizlarlaSekilCizme3
{
    class Program
    {
        static void Main(string[] args)
        {
            int kenar;

            Console.Write("Kenar sayisini girin:");
            kenar = int.Parse(Console.ReadLine());

            //ust kenar
            for (int i = 0; i < kenar ; i++)
            {
                Console.Write("* ");
            }

            Console.WriteLine("");

            //yan kenarlar
            for (int j = 0; j < kenar - 2; j++)
            {
                Console.Write("*");

                //aradaki bosluklar

                for(int k = 0; k < kenar - 2; k++)
                {
                    Console.Write("  ");
                }

                Console.Write(" *");
                Console.WriteLine("");
                
            }

            //alt kenar
            for (int i = 0; i < kenar; i++)
            {
                Console.Write("* ");
            }

            Console.ReadLine();
        }
    }
}