using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    class CalculateAge
    {
        public static int CalculateAges(List<Animal> list)
        {
            int sum = 0;
            foreach(var animal in list)
            {
                sum += animal.age;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            var animals = new List<Animal>()
            {
                new Dog("Sharo","male",4),
                new Kitten("Lisa",5),
                new Frog("Mr.Frog","male",1),
                new TomCat("Tom",7),
                new Dog("Rex","male",8),
                new Dog("Merry","female",6)
            };

            int sumOfAges = CalculateAges(animals);
            Console.WriteLine(sumOfAges);
        }
    }
}
