using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
     class ProductManager  //Şu yandaki yazım doğru bir yazım Kelimelerin ilk harfleri her zaman büyük
       
    {
        //encapsulation
        public void Add(Product product) //adresi 101 olsun
        {
            product.ProductName = "Kamera"; //classa atama  yaptık .dolayısıyla referans tipi değer olduğundan main de kamera diye okunur.

            Console.WriteLine(product.ProductName + " eklendi. ");

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi. ");

        }

        //nerede void nerede int kullanırız?
        public int Topla(int x,int y)
        {
            return x + y; //bu sonucu başka yerde de kullanmak istiyorum

        }

        public void Topla2(int x, int y)
        {
            Console.WriteLine(x + y); 

        }


    }
}
