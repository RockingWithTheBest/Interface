using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();
            Dog dog = new Dog();
            Cat cat = new Cat();
            animals.Add(dog);
            animals.Add(cat);
            foreach(IAnimal animal in animals)
            {
                animal.MakeSound();
            }
            Cat cat2 = new Cat();
            Lion lion = new Lion();
        }
    }

    public interface IAnimal
    {
        int Legs { get; }
        void MakeSound();   
    }
    public interface IJungel:IAnimal {
        void Habitation();
    }
    public class Lion : Cat,  IAnimal , IJungel 
    {
        public void Roll()
        {
            Console.WriteLine("roll");
        }
        public void Habitation()
        {
            Console.WriteLine("Lives in the jungle");
        }
    }
    public class Dog : IAnimal
    {
        public int Legs { get; }

        public  void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
    public class Cat : IAnimal
    {
        public int Legs { get; }

        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
    
}
