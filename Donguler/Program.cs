using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string k1 = "Yazılım Geliştirici kampı";
            string k2 = "Programlamaya giriş kampı";
            string k3 = "Java"; //tek tek tanımlamak sıkıntı

            //array -dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici kampı", "Programlamaya giriş kampı", "Java","Mobil Kodlama","Dijital Pazarlama","SEO","Wordpress" };

            foreach (string kurs in kurslar) //for ile aynı işlevde ama bu daha verimli
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("************");
            Console.WriteLine("");
            Console.WriteLine("Sayfa sonu foreach bitti");
            Console.WriteLine("");
            

            for (int i = 0; i < kurslar.Length; i++)
            {
               
                Console.WriteLine(kurslar[i]);
    
            }
            Console.WriteLine("************");
            Console.WriteLine("");
            Console.WriteLine("Sayfa sonu for bitti");
            Console.Read();

        }
    }
}
