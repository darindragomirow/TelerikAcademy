﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.UsingClassesAndObjects
{
    class IsLeapYear
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());

            if(DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
            

            




        }
    }
}