using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asagidaki memberlerden ibaret Book class-i yaradirsiniz: 
            // Name
            // PageCount
            // ps: name ve count deyerleri teyin olunmammis Book obyekti yaranmamalidir.
            // PageCount deyeri 10-dan kicik
            // ola bilmez ve Name deyerinin uzunlugu 3-den qisa ola bilmez Main hissesinde 10 kitabliq Book arrayi
            // olsun.Kitab deyerleri console-dan daxil edilsin ve yaradilsin, array-e elave edilsin.
            // Sonda arraydeki kitablarin Name ve PageCount deyerleri console penceresinde gosterilsin/



            Book[] arr = new Book[2];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i + 1} Kitabını daxil et: ");
                string book_name = Console.ReadLine();
                Console.WriteLine($"{i +1} Kitabın səhifəsini daxil et: ");
                int book_page;
                int.TryParse(Console.ReadLine(), out book_page);

                Book book = new Book(book_name, book_page);
                arr[i] = book;
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item.Info());
            }

        }
    }
}
