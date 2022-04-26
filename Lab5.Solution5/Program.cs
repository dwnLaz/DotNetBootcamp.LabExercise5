using System;


namespace Lab5.Solution5
{
    public abstract class Animal
    {
        private string Name;

        public void SetName(string animalName)
        {
            Name = animalName;
        }

        public string GetName()
        {
            return Name;
        }

        public abstract void Eat();
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.Write($" is Eating");
        }
    }


    public class AbstractClass
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.Write("Enter dog name: ");
            dog.SetName(Console.ReadLine());
            Console.Write(dog.GetName());
            dog.Eat();
        }

    }
}