using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;  //int değer tipi döndürür sadece değeri kopyalayıp değeri değiştirir.Olay sadece değeri atamaktır.int 2 ile tüm bağlar atama sonrası kopar
            Console.WriteLine(sayi1);

            //bellekte 2 yer var(Stack ve Heap) değer tipler stackte referens tipler heap te 
            //new demek heapte yeni bir adres,yer oluştur anlamına gelir

            int[] sayilar1 = new int[] { 10,20,30};
            int[] sayilar2 = new int[] { 100, 200, 300};
            sayilar1 = sayilar2;
            sayilar2[0] = 999;  //diziler referans tipi döndürür
            Console.WriteLine(sayilar1[0]);

        }
    }
}
