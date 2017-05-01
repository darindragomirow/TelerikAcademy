using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DefineClass
{
    class CallHistoryTest
    {
        public static void Main()
        {
            GSM gsm = new GSM("SamsungS5", "Samsung");
            gsm.AddCall(new Call(new DateTime(2016, 12, 17), "0883505366", 300));
            gsm.AddCall(new Call(new DateTime(2016, 12, 17), "0887441232", 200));
            gsm.AddCall(new Call(new DateTime(2016, 12, 17), "0878335421", 100));
            foreach(Call call in gsm.CallHistory)
            {   
                Console.WriteLine(call.ToString());
            }
            //Print the total call price
            gsm.CalculateCallPrice(0.37);
            Console.WriteLine();
           
            //Find the largest call
            Call longestCall = null; ;
            int longestDuration=0;
            foreach(Call call in gsm.CallHistory)
            {
                if(call.Duration>longestDuration)
                {
                    longestDuration = call.Duration;
                    longestCall = call;
                }
            }
            //Remove the longest call from history
            Console.WriteLine("The longest call has duration:{0}",longestCall.Duration);
            gsm.DeleteCall(longestCall);
            Console.WriteLine("After deleting the longest call:");
            gsm.CalculateCallPrice(0.37);
            Console.WriteLine();

            //Clear the call history and print it
            gsm.DeleteCallHistory();
            Console.WriteLine("Call History:");
            foreach (Call call in gsm.CallHistory)
            {
                Console.WriteLine(call.ToString());
            }
           
            
        }
        
    }
}
