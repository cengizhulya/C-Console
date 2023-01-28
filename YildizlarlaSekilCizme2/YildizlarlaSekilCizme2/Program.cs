using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YildizlarlaSekilCizme2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ters Dik Ucgen Cizme
            

            for(int i=0; i<10; i++)
            {
                for (int j=10; j>i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.ReadLine();
            


            /*
            for (int i=10; i>0; i--)
            {
                for (int j=i; j>=1 ; j--)
                {
                    Console.Write("*");
                   
                }

                Console.WriteLine("");

            }

            Console.ReadLine();
            */
        }
    }
}