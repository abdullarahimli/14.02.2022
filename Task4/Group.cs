using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Group
    {
        public string No;
        public int Limit;
        private Student[] _students ;


        public Group(string no, int limit)
        {
            No = no;
            Limit = limit;
            _students = new Student[0];
        }   
        public void AddStudent(Student stu)
        {
            if (_students.Length < Limit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = stu;
            }
            else
            {
                Console.WriteLine("Qrup doludur");
            }
        }

        public void GetStudents()
        {
            foreach (var item in _students)
            {
                Console.WriteLine($" Adı - {item.Name}; Soyadı {item.SurName}; Group - {No}");
            }
            
        }
    }
    
 


}
