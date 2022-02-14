using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class User
    {
        private string _UserName;
        private string _Password;

        public User(string username)
        {
            IstAdi = username;
            _Password = Parol;
        }

        public string IstAdi
        {
            get
            {
                return _UserName;
            }
            set
            {
                
                while (true)
                {
                    if (value.Length > 8)
                    {
                        _UserName = value;
                        
                    }
                    else if (value.Length < 8)
                    {
                        Console.WriteLine("İstifadəçi adının uzunluğu 8 simvoldan az ola bilməz !");
                        
                        break;
                    }
                    
                }
            }
        }

        public string Parol
        {
            get
            {
                return _Password;
            }
            set
            {
                while (true)
                {
                    if (value.Length >= 8)
                    {
                        Parol = _Password;
                        break;
                    }
                    else if (value.Length < 8)
                    {
                        Console.WriteLine("Parol 8 imvoldan az ola bilməz !");
                        int.Parse(Console.ReadLine());
                        
                    }
                }
            }
        }
    }
}