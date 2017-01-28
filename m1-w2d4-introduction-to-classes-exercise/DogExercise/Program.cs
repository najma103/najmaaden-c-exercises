using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechElevator.Classes;

namespace DogExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();

            d1.Sleep();
            Console.WriteLine("dog is sleeping " + d1.isSleeping);
        }
    }
}
