using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Product
    {
        public string Name;
        public double Price;
        public int Count;
        public double TotalIncome;


        public Product(string name)
        {
            Name = name;
            Price = 2.60;
            Count = 15;
            TotalIncome = Count * Price;
        }

        public void Sell()
        {
            if (Count > 0)
            {
                Count--;
                
                TotalIncome += Price;
            }
            else if (Count == 0)
            {
                
                Console.WriteLine("Məhsul bitmişdir");
            }
            
          
        }


    }
}
