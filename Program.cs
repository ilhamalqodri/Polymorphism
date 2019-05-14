using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatPoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Speak();

            Cat cat = new Cat();
            animal = cat;
            cat.Speak();

            Chicken chicken = new Chicken();
            animal = chicken;
            chicken.Speak();

            Dog dog = new Dog();
            animal = dog;
            dog.Speak();

            Console.ReadKey();
        }
    }
}
