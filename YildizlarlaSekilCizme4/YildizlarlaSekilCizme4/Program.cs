using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YildizlarlaSekilCizme4
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger;
            Console.Write("Baklava diliminin buyukluk sayisini girin:");
            deger = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i<=deger; i++)
            {
                for(int j = deger; j > i; j--)
                {
                    Console.Write(" ");
                }

                for(int k =1; k <= i; k++)
                {
                    Console.Write("*"+" ");
                }
                Console.WriteLine();
            }

            for(int l=1;l<=deger; l++)
            {
                for(int m=1; m <= l; m++)
                {
                    Console.Write(" ");
                }

                for(int n = deger; n > l; n--)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}