using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    public class Animal
    {
        public Animal(string name,string sex,int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }
        public string name { get; private set; }
        public int age { get; private set; }
        public string sex { get; private set; }

        
    }
}
