using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // method overriding = provides a new version of a method inherited from a paren class
            //                     inherited method mus be: abstract, virtual, or already overriden
            //                     Used with ToString(), polymorphism

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

            Console.ReadKey();
        }
    }

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woff*");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes *meow*");
        }
    }
}