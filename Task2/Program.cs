using System;

namespace Task2
{
    class Program
    {
        /* 
         * Asagidaki member-lerden ibaret Product class-i yaradin:
         * Name - mehsulun adi
         * Price - mehsulun qiymeti
         * Count - mehsulun sayi
         * TotalIncome - bu mehsulun satislarindan elde olunan umumi gelir
         * Sell() - mehsulun satisi metodu.Bu metod Product-dan bir eded satilmasini ifade edir.
         * Satis bas verdikde say azalir (productin sayi sifirdisa satis bas vere bilmez) ,
         * income artir Name fieldininn value-su teyin olunmamsis bir product obyekti yaradila bilinmemelidir.
         * Asagidaki memberlerden ibared Milk class - i yaradin ve Productdan miras verin:
         * Volume - Bu xususiyyet Milkin hecmini ifade edir (Litr olaraq)
         * FatRate - Bu xususiyyet sudun yagliliq faizini ifade edir (sudun nece faiz yagli oldugunu)
         */

        static void Main(string[] args)
        {
            Product product = new Product("Azersud");
            
            Milk milk = new Milk();

            product.Sell();

            Console.WriteLine(product.Count);
            //Console.WriteLine(milk.Name);
            //Console.WriteLine(milk.Price);
            //Console.WriteLine(milk.Count);
            //Console.WriteLine(milk.TotalIncome);
            //Console.WriteLine(milk.FatRate);
            //Console.WriteLine(milk.Volume);
        }
    }
}
