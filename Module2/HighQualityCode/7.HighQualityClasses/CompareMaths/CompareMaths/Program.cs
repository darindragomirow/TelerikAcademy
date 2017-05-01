using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareMaths
{
    class CompareSimpleMaths
    {
        static void Main(string[] args)
        {
            //ADD
            int sumInt = 0;
            long sumLong = 0;
            double sumDouble = 0;
            float sumFloat = 0;
            decimal sumDecimal = 0;

            //Int
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 100;i++)
            {
                sumInt += i;
            }
            stopWatch.Stop();
            Console.WriteLine("Time for summing 100 ints:"+stopWatch.Elapsed);

            //Long
            stopWatch.Restart();
            for (int i = 0; i < 100; i++)
            {
                sumLong += i;
            }
            stopWatch.Stop();
            Console.WriteLine("Time for summing 100 longs:" + stopWatch.Elapsed);

            //Double
            stopWatch.Restart();
            for (double i = 0; i < 100; i++)
            {
                sumDouble += i;
            }
            stopWatch.Stop();
            Console.WriteLine("Time for summing 100 doubles:" + stopWatch.Elapsed);

            //Float
            stopWatch.Restart();
            for (float i = 0; i < 100; i++)
            {
                sumFloat += i;
            }
            stopWatch.Stop();
            Console.WriteLine("Time for summing 100 floats:" + stopWatch.Elapsed);

            //Decimal
            stopWatch.Restart();
            for (decimal i = 0; i < 100; i++)
            {
                sumDecimal += i;
            }
            stopWatch.Stop();
            Console.WriteLine("Time for summing 100 decimals:" + stopWatch.Elapsed);


            //Subtract
            //Int
            stopWatch.Restart();
            for (int i = 0; i < 100; i++)
            {
                sumInt -= 1;
            }
            stopWatch.Stop();
            Console.WriteLine("Time for subtracting 100 ints:" + stopWatch.Elapsed);

            //Long
            stopWatch.Restart();
            for (long i = 0; i < 100; i++)
            {
                sumLong -= 1;
            }
            stopWatch.Stop();
            Console.WriteLine("Time for subtracting 100 longs:" + stopWatch.Elapsed);

            //Double
            stopWatch.Restart();
            for (double i = 0; i < 100; i++)
            {
                sumDouble -= 1;
            }
            stopWatch.Stop();
            Console.WriteLine("Time for subtracting 100 doubles:" + stopWatch.Elapsed);

            //Float
            stopWatch.Restart();
            for (float i = 0; i < 100; i++)
            {
                sumFloat -= 1;
            }
            stopWatch.Stop();
            Console.WriteLine("Time for subtracting 100 floats:" + stopWatch.Elapsed);

            //Decimal
            stopWatch.Restart();
            for (decimal i = 0; i < 100; i++)
            {
                sumDecimal -= 1;
            }
            stopWatch.Stop();
            Console.WriteLine("Time for subtracting 100 decimals:" + stopWatch.Elapsed);


            //Increment
            //Int
            stopWatch.Restart();
            for (int i = 0; i < 100; i++)
            {
                sumInt++;
            }
            stopWatch.Stop();
            Console.WriteLine("Time for incrementing ints:" + stopWatch.Elapsed);

            //Long
            stopWatch.Restart();
            for (int i = 0; i < 100; i++)
            {
                sumLong++;
            }
            stopWatch.Stop();
            Console.WriteLine("Time for incrementing longs:" + stopWatch.Elapsed);

            //Double
            stopWatch.Restart();
            for (int i = 0; i < 100; i++)
            {
                sumDouble++;
            }
            stopWatch.Stop();
            Console.WriteLine("Time for incrementing doubles:" + stopWatch.Elapsed);

            //Float
            stopWatch.Restart();
            for (int i = 0; i < 100; i++)
            {
                sumFloat++;
            }
            stopWatch.Stop();
            Console.WriteLine("Time for incrementing floats:" + stopWatch.Elapsed);

            //Decimal
            stopWatch.Restart();
            for (int i = 0; i < 100; i++)
            {
                sumDecimal++;
            }
            stopWatch.Stop();
            Console.WriteLine("Time for incrementing decimals:" + stopWatch.Elapsed);

            //Multiply
            //Int
            stopWatch.Restart();
            for(int i = 0; i < 10;i++)
            {
                sumInt *= i;
            }
            stopWatch.Stop();
            Console.WriteLine("Time for multiplying 10 ints:"+stopWatch.Elapsed);

            //Long
            stopWatch.Restart();
            for (long i = 0; i < 10; i++)
            {
                sumLong *= i;
            }
            stopWatch.Stop();
            Console.WriteLine("Time for multiplying 10 longs:" + stopWatch.Elapsed);


            //Double
            stopWatch.Restart();
            for (double i = 0; i < 10; i++)
            {
                sumDouble *= i;
            }
            stopWatch.Stop();
            Console.WriteLine("Time for multiplying 10 doubles:" + stopWatch.Elapsed);

            //Float
            stopWatch.Restart();
            for (float i = 0; i < 10; i++)
            {
                sumFloat *= i;
            }
            stopWatch.Stop();
            Console.WriteLine("Time for multiplying 10 floats:" + stopWatch.Elapsed);

            //Decimal
            stopWatch.Restart();
            for (decimal i = 0; i < 10; i++)
            {
                sumDecimal *= i;
            }
            stopWatch.Stop();
            Console.WriteLine("Time for multiplying 10 decimals:" + stopWatch.Elapsed);




        }
    }
}
