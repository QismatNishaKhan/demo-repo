using System;

namespace _1program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "qismat");
            string value = s.GetStudentName();
            Console.WriteLine("value1");
        }
        public class Student
        {
            public int Id;
            public String Name;
            

            public Student(int id ,string name)
            {
                Id = id;
                Name = name;
            }
            public string GetStudentName()
            {
                return Name;
            }
        }
    }
}
