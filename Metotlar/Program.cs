using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Aciklama = "Amasya elması";
            urun1.Fiyati = 15;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 90;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (Urun urun in urunler) //type safe -- tip güvenliği demek
            {
                Console.WriteLine("Ürün adı: " + urun.Adi);
                Console.WriteLine("Ürün açıklaması: " + urun.Aciklama);
                Console.WriteLine("Ürün fiyatı: " + urun.Fiyati);

                Console.WriteLine("******");

            }

            Console.WriteLine("------METOTLAR--------");

            SepetManager sm = new SepetManager();
           
            sm.Ekle(urun1);
            sm.Ekle(urun2);
            sm.ekle2("Armut","Yeşil armut",12,1);
            sm.ekle2("Muz", "Yeşil muz", 12,4);


            Console.Read();


            
    }
    }
}
