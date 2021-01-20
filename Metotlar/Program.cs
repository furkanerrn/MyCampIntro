using System;
using System.Linq;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            //string[] meyveler = new string[] { };

            //Urun urun1 = new Urun();
            //urun1.Adi = "Elma";
            //urun1.Aciklama = "Amasya elması";
            //urun1.Fiyati = 15;

            //Urun urun2 = new Urun();
            //urun2.Adi = "Karpuz";
            //urun2.Fiyati = 90;
            //urun2.Aciklama = "Diyarbakır Karpuzu";

            //Urun[] urunler = new Urun[] { urun1, urun2 };
            //foreach (Urun urun in urunler) //type safe -- tip güvenliği demek
            //{
            //    Console.WriteLine("Ürün adı: " + urun.Adi);
            //    Console.WriteLine("Ürün açıklaması: " + urun.Aciklama);
            //    Console.WriteLine("Ürün fiyatı: " + urun.Fiyati);

            //    Console.WriteLine("******");

            //}

            //Console.WriteLine("------METOTLAR--------");

            //SepetManager sm = new SepetManager();

            //sm.Ekle(urun1);
            //sm.Ekle(urun2);
            //sm.ekle2("Armut","Yeşil armut",12,1);
            //sm.ekle2("Muz", "Yeşil muz", 12,4);


            //Console.Read();


            //add();
            //add2("furkan","eren");
            int number1 ;
            int number2 = 10;
            var result=add3(out number1, number2);  // ref değer tipi referans tip olarak döndürmeye yarar.
             
            Console.WriteLine(result);
            Console.WriteLine(number1);
            Console.WriteLine(add4(5,7,9,45,78,21,65));
            string[] students ={ "mert", "metin", "tekin" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.Read();


        }
        static void add()
        {
            Console.WriteLine("Added");
        }
        static void add2(string ad,string soyad)
        {
            Console.WriteLine("name: "+ad +" surname: "+soyad+ " added complted" );
        }

        static int add3( out int n1,int n2)  //ref ile out mantığı aynı . Tek fark out u değer girmeden de referans edebiliriz fakat red kullanırsak ve değer vermezsek hata verir
        {
            n1 = 30; //out kullanımında değerin mutlaka set edilmesi lazım (en az 1 kere)
            return n1 + n2;
        }

        static int add4(params int[] numbers) //params sınırsız sayıda sayı girmemizi sağlar
        {
             return numbers.Sum();
        }
    }
}
