using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BuyukSayiMetot
{
    class Program
    {
        //Gönderilen iki sayıdan büyük olanı geri gönderen metodu oluşturunuz.
        private static int buyukSayi_(int sayi1, int sayi2)
        {
            if (sayi1 > sayi2)
            {
                Console.Write("Buyuk sayi:");

                return sayi1;
            }
            else
            {
                Console.Write("Buyuk sayi:");

                return sayi2;
            }
        }


        /*
        private static void buyukSayi (int sayi1, int sayi2)
        {
            if(sayi1 > sayi2)
            {
                Console.Write("Buyuk sayi:"+sayi1);
            }
            else
            {
                Console.Write("Buyuk sayi:"+sayi2);
            }
        }
        */

        static void Main(string[] args)
        {
            int sayi1_;
            int sayi2_;

            Console.Write("1.sayiyi girin:");
            sayi1_ = int.Parse(Console.ReadLine());

            Console.Write("2.sayiyi girin:");
            sayi2_ = int.Parse(Console.ReadLine());

            Console.WriteLine(buyukSayi_(sayi1_, sayi2_) ); 

            Console.ReadLine();
        }
    }
  



}
