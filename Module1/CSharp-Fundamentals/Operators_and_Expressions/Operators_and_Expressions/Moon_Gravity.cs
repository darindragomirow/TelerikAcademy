using System;


namespace Operators_and_Expressions
{
    class Moon_Gravity
    {
        public static void Main()
        {
            float weightOnEarth = float.Parse(Console.ReadLine());
            float weightOnMoon = (float)(weightOnEarth * 0.17);
            Console.WriteLine(weightOnMoon.ToString("f3"));
            Console.WriteLine(long.MaxValue);
        }
    }
}
