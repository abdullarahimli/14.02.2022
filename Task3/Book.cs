using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Book
    {
        private string _name;
        private int _pageCount;
        
        public Book(string name, int count)
        {
            İsim = name;
            Sehife = count;
        }

        public int Sehife
        {
            get
            {
                return _pageCount;
            }
            set
            {
                while (true)
                {
                    if (value > 10)
                    {
                        _pageCount = value;
                        break;
                    }
                    else if (value < 10)
                    {
                        Console.WriteLine("Kitab səhifəsi 10 dan kiçik ola bilməz");
                        int.TryParse(Console.ReadLine(), out value);
                    }
                    else
                    {
                        Console.WriteLine("Duzgun deyer daxil et");
                        int.TryParse(Console.ReadLine(), out value);
                    }
                }
            }
        }

        public string İsim
        {
            get
            {
                return _name;
            }
            set
            {
                while (true)
                {
                    if (value.Length > 3)
                    {
                        _name = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Duzgun deyer daxil et");
                        value = Console.ReadLine();
                    }
                }
                
            }
        }

        public string Info()
        {
            return $"{_name} kitabı {_pageCount} səhifədən ibarətdir.";
        }
    }
}
