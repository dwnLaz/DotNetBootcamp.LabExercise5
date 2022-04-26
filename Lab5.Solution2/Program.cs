using System;

namespace Lab5.Solution2
{
    class Person
    {
        public int Age { get; set; }
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int age)
        {
            Age = age;
        }
    }
    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} years old", Age);
        }
    }
    class Professor : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining.");
        }
    }
    class StudentProfessorTest
    {

        static void Main(string[] args)
        {
            Console.WriteLine("--- Person ---");
            Person person = new Person();
            person.Greet();

            Console.WriteLine("\n--- Student ---");
            Student student = new Student();
            student.SetAge(10);
            student.Greet();
            student.ShowAge();


            Console.WriteLine("\n--- Professor ---");
            Professor professor = new Professor();
            professor.SetAge(25);
            professor.Greet();
            professor.Explain();
        }
    }
}
