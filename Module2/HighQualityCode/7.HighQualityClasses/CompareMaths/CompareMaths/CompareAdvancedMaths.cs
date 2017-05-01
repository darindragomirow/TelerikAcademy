using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareMaths
{
    class CompareAdvancedMaths
    {
       public static void Main()
        {
            int resultInt = 0;
            float resultFloat = 0;
            double resultDouble = 0;
            long resultLong = 0;
            decimal resultDecimal = 0;

            var stopWatch = new Stopwatch();
            Console.WriteLine("Testing Square root:");
            //Int 
            stopWatch.Start();
            resultInt = (int)Math.Sqrt(3.14);
            stopWatch.Stop();
            Console.WriteLine("INT:"+stopWatch.Elapsed);
            //Long
            stopWatch.Restart();
            resultLong = (long)Math.Sqrt(3.14);
            stopWatch.Stop();
            Console.WriteLine("LONG:"+stopWatch.Elapsed);
            //Double
            stopWatch.Restart();
            resultDouble = (double)Math.Sqrt(3.14);
            stopWatch.Stop();
            Console.WriteLine("DOUBLE:" + stopWatch.Elapsed);
            //Float
            stopWatch.Restart();
            resultFloat = (float)Math.Sqrt(3.14);
            stopWatch.Stop();
            Console.WriteLine("FLOAT:" + stopWatch.Elapsed);
            //Decimal
            stopWatch.Restart();
            resultDecimal = (decimal)Math.Sqrt(3.14);
            stopWatch.Stop();
            Console.WriteLine("DECIMAL:" + stopWatch.Elapsed);


            Console.WriteLine("Testing Natural Logarithms:");
            //Int 
            stopWatch.Restart();
            resultInt = (int)Math.Log(3.14);
            stopWatch.Stop();
            Console.WriteLine("INT:" + stopWatch.Elapsed);
            //Long
            stopWatch.Restart();
            resultLong = (long)Math.Log(3.14);
            stopWatch.Stop();
            Console.WriteLine("LONG:" + stopWatch.Elapsed);
            //Double
            stopWatch.Restart();
            resultDouble = (double)Math.Log(3.14);
            stopWatch.Stop();
            Console.WriteLine("DOUBLE:" + stopWatch.Elapsed);
            //Float
            stopWatch.Restart();
            resultFloat = (float)Math.Log(3.14);
            stopWatch.Stop();
            Console.WriteLine("FLOAT:" + stopWatch.Elapsed);
            //Decimal
            stopWatch.Restart();
            resultDecimal = (decimal)Math.Log(3.14);
            stopWatch.Stop();
            Console.WriteLine("DECIMAL:" + stopWatch.Elapsed);


            Console.WriteLine("Testing Sinus:");
            //Int 
            stopWatch.Restart();
            resultInt = (int)Math.Sin(3.14);
            stopWatch.Stop();
            Console.WriteLine("INT:" + stopWatch.Elapsed);
            //Long
            stopWatch.Restart();
            resultLong = (long)Math.Sin(3.14);
            stopWatch.Stop();
            Console.WriteLine("LONG:" + stopWatch.Elapsed);
            //Double
            stopWatch.Restart();
            resultDouble = (double)Math.Sin(3.14);
            stopWatch.Stop();
            Console.WriteLine("DOUBLE:" + stopWatch.Elapsed);
            //Float
            stopWatch.Restart();
            resultFloat = (float)Math.Sin(3.14);
            stopWatch.Stop();
            Console.WriteLine("FLOAT:" + stopWatch.Elapsed);
            //Decimal
            stopWatch.Restart();
            resultDecimal = (decimal)Math.Sin(3.14);
            stopWatch.Stop();
            Console.WriteLine("DECIMAL:" + stopWatch.Elapsed);




        }
    }
}
