using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class Metotlar
    {
    
        static void Main(string[] args)
        {
            Ogrenci ogrenci_ = new Ogrenci();

            ogrenci_.AD = "Hilal";
            ogrenci_.SOYAD = "Cengiz";
            ogrenci_.YAS = 21;

            Console.WriteLine("Adi:"+ogrenci_.AD);
            Console.WriteLine("Soyadi:"+ogrenci_.SOYAD);
            Console.WriteLine("Yas:"+ogrenci_.YAS);

            Console.ReadLine();
        }
    }
}