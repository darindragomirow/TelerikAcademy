using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Delegates_LINQ
{
   public static class IEnumerableExtensions
    {
       public static T Sum<T>(this IEnumerable<T> list)
           where T:IComparable<T>    
       {
           T sum=default(T);
           foreach(T element in list)
           {
               sum += (dynamic)element;
           }
           return sum;
       }

       public static T Product<T>(this IEnumerable<T> list)
           where T:IComparable<T>
       {
           T product = (dynamic)1;

           foreach(T element in list)
           {
               product *= (dynamic)element;
           }
           return product;
       }

       public static T Average<T>(this IEnumerable<T> list)
           where T : IComparable<T>
       {
           T sum = (dynamic)list.Sum();
           T average = (dynamic)sum / list.Count();
           return average;
       }
    
       public static T Max<T>(this IEnumerable<T> list)
       {
           T max = (dynamic)list.ElementAt(0);

           foreach(T element in list)
           {
               if((dynamic)element>max)
               {
                   max = element;
               }
           }
           return max;
       }

       public static T Min<T>(this IEnumerable<T> list)
       {
           T min = (dynamic)list.ElementAt(0);

           foreach (T element in list)
           {
               if ((dynamic)element < min)
               {
                   min = element;
               }
           }
           return min;
       }



    }
}
