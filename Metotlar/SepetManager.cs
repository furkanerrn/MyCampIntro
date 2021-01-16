using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
           Console.WriteLine(urun.Adi+ " sepete eklendi ");
        }

        public void ekle2(string urunadi,string açiklama,double fiyat,int stokAdet)
        {
            Console.WriteLine("Tebrikler "+ urunadi + " sepete eklendi ");
            Console.WriteLine(urunadi+" Stok Adeti:  "+stokAdet);
        }

    }
}
