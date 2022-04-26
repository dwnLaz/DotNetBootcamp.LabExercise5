using System;

namespace Lab5.Solution3
{
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            //Console.WriteLine($"Hello! My name is {Name}\n");
            return $"Hello! My name is {Name}";
        }
    }

    class Student : Person
    {
        public Student(string name) : base(name)
        {
            this.Name = name;
        }

        public void Study()
        {
            Console.WriteLine("Student is studying.");
        }
    }

    class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
            this.Name = name;
        }
        public void Explain()
        {
            Console.WriteLine("Teacher is explaining.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Person[] people = new Person[3];
            for (int i = 0; i < people.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("Enter Teacher Name: ");
                    string teacherName = Console.ReadLine();

                    if (teacherName.Trim().Equals("") || teacherName == null)
                    {
                        Console.WriteLine("Please enter a valid name.");
                        i--;
                    }
                    else
                    {
                        Teacher teacher = new Teacher(teacherName);
                        Console.WriteLine(teacher.ToString());
                        teacher.Explain();
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.Write("Enter Student Name: ");
                    string studentName = Console.ReadLine();

                    if (studentName.Trim().Equals("") || studentName == null)
                    {
                        Console.WriteLine("Please enter a valid name.");
                        i--;
                    }
                    else
                    {
                        Student student = new Student(studentName);
                        Console.WriteLine(student.ToString());
                        student.Study();
                        Console.WriteLine();
                    }
                }
            }


        }
    }
}
