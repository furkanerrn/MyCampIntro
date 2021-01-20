using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInstock = 3;

            Product product2 = new Product
            {

                Id = 2,
                CategoryId = 5,
                UnitInstock = 5,
                ProductName = "Kalem",
                UnitPrice=35

            };
            //Pascal case=kelimenin ilk harfi büyük  //camelCase: örneklemede 
            ProductManager productManager = new ProductManager();  //bellekteki adres
            //eşitliğin solu belleğin Stack , sağı ise belleğin heap kısmında oluşturulur
            productManager.Add(product1);

           
             

            Console.WriteLine(product1.ProductName);

            // int, double ,bool değer tipli veriler

            //diziler classlar interfaceler referans tip

            int result = productManager.Topla(3, 6); // voidsiz
            Console.WriteLine(result*2); //geriye dönen değeri başka yerde de kullanabildim.

         //  var res= productManager.Topla2(6, 7); //Burada geriye değer döndüremiyoruz çünkü yok

            

        }
    }
}
