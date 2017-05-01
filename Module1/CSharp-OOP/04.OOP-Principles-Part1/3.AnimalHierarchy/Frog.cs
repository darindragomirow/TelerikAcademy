using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    public class Frog:Animal,ISound
    {
        public Frog(string name,string sex,int age):base(name,sex,age)
        {

        }
        public void Sound()
        {
            Console.WriteLine("Krrr!");
        }
    }
}
