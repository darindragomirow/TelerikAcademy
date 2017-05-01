using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_4yek
{
    class BasicClass
    {
        enum Gender { male, female};
        class Human
        {
            public Gender Gender { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public void CreateHuman(int age)
        {
            Human newHuman = new Human();
            newHuman.Age = age;
            if (age % 2 == 0)
            {
                newHuman.Name = "Батката";
                newHuman.Gender = Gender.male;
            }
            else
            {
                newHuman.Name = "Мацето";
                newHuman.Gender = Gender.female;
            }
        }
    }
}
