using System;

namespace Lab5.Solution1
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public override string ToString()
            {
                return $"Person Name: {Name}";
            }
        }
        
        static void Main(string[] args)
        {
            Person[] people = new Person[3];
            for (int i = 0; i < people.Length; i++)
            {
                Console.Write("Enter Name: ");
                string userInput = Console.ReadLine();

                if (userInput.Trim().Equals("") || userInput == null)
                {
                    Console.WriteLine("Please enter a valid name.");
                    i--;
                }
                else
                {
                    Person person = new Person()
                    {
                        Name = userInput
                    };
                    people[i] = person;
                }
            }

            foreach (var p in people)
            {
                Console.WriteLine(p.ToString());
            }


        }
    }
}
