using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TekSayiKontrolMetot
{
    class Program
    {
        //Klavyeden girilerek parametre olarak gönderilen bir sayının, tek olup olmadığını kontrol eden, eğer sayı tek ise true, değilse false değeri döndüren metodu yazınız.

        private static bool tekKontrol (int sayi)
        {
            if (sayi % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void Main(string[] args)
        {

            int sayi_;

            Console.Write("Bir sayi girin:");

            sayi_ = int.Parse(Console.ReadLine());

            bool cikti = tekKontrol(sayi_);

            Console.WriteLine(cikti);

            Console.ReadLine();
        }
    }
    
}
