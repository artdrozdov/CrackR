using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackR.StacksAndQueues
{
    public class AnimalQueue
    {
        private List<Animal> animals = new List<Animal>();

        public void Enqueue(Animal animal)
        {
            animals.Add(animal);
        }

        public Animal Dequeue()
        {
            return animals.FirstOrDefault();
        }

        public Cat DequeueCat()
        {
            return animals.FirstOrDefault(x => x is Cat) as Cat;
        }

        public Dog DequeueDog()
        {
            return animals.FirstOrDefault(x => x is Dog) as Dog;
        }
    }

    public abstract class Animal
    {
        public int Age { get; set; }
    }

    public class Dog : Animal
    {
        
    }

    public class Cat : Animal
    {
        
    }
}
