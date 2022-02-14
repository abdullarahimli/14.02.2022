using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("P225", 3);

            Student student = new Student("Abdulla", "Rahimli");
            Student student1 = new Student("Vusal", "Imanov");
            Student student2 = new Student("Vusal", "Imanov");
            Student student3 = new Student("Vusal", "Imanov");
            group.AddStudent(student);
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.GetStudents();
        }
    }
}
