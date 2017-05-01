using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    public class TomCat:Cat,ISound
    {
        public TomCat(string name,int age):base(name,"Male",age)
        {

        }
        public void Sound()
        {
            Console.WriteLine("Mrrr!");
        }
    }
}
