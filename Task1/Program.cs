using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Istifadeci adini daxil edin: ");
            User user = new User(Console.ReadLine());
            Console.WriteLine("Sifreni  daxil edin: ");
            User sifre = new User(Console.ReadLine());
        }
    }
}
