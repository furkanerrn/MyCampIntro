using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            
          
            Kurs k1 = new Kurs();
            k1.KursAdi = "C#";
            k1.egitmen = "Engin Demirog";
            k1.IzlenmeOrani = 78;

            Kurs k2 = new Kurs();
            k2.KursAdi = "Excel";
            k2.egitmen = "Ömer Çolak";
            k2.IzlenmeOrani = 57;

            Kurs k3 = new Kurs();
            k3.KursAdi = "SEO";
            k3.egitmen = "Fikret Kozak";
            k3.IzlenmeOrani = 57;

            Kurs k4 = new Kurs();
            k4.KursAdi = "Java";
            k4.egitmen = "Atıl Samancıoğlu";
            k4.IzlenmeOrani = 89;


            Kurs[] kurslar = new Kurs[] { k1, k2, k3, k4};
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine("Kurs Adı:"+kurs.KursAdi + "  Eğitmen:"+kurs.egitmen);
                Console.WriteLine("");
            }
            Console.ReadLine();

           // Console.WriteLine(k1.KursAdi +" "+ k2.KursAdi +  " " + k3.KursAdi );
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
