using System;
using System.Collections.Generic;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        { //type safety - tip güvenliği

            string ad = "furkan";
            string kategorietiketi = "kategori";
            int ögsayi = 32000;
            double faiz = 1.45; //ondalık sayılar 
            bool SistemeGirdimi = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            Console.Read();




            Console.WriteLine("Kategori yorumu");  //serbest metin 
            Console.WriteLine(kategorietiketi); // dğişken atanmış metin
            Console.WriteLine(SistemeGirdimi);

            if (SistemeGirdimi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            
           
         



          
        }
    }
}
