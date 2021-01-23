using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic'ler hangi veri tipini girersen içerisindeki fonksiyonlar parametre olarak o veri tipini istiyorlar
            // List<string> sehirler = new List<string>(); // Generic yapıda klasik bir List nesnesi
            // metotlar kullanılırken () işareti olur eğer yoksa property dir
            MyList<string> sehirler2 = new MyList<string>();
            string eleman = "";
            string deger = "";
            while (true)
            {
                Console.WriteLine("Devam edilsin mi?(q = çıkış) ");
                deger = Console.ReadLine();
                if (deger == "q" || deger == "Q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Eklenecek olan elemanı girin: ");
                    eleman = Console.ReadLine();
                    sehirler2.Add(eleman);
                }
            }

            sehirler2.View();

            Console.WriteLine("Liste içerisindeki eleman sayısı: "+sehirler2.MyCount);

        }
    }
}
