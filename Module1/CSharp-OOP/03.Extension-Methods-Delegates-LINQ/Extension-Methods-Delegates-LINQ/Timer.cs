using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Extension_Methods_Delegates_LINQ
{
    class Timer
    {
        public  delegate void TimerDelegate();

        public int seconds { get; set; }
        public int times { get; set; }

        public TimerDelegate method { get; set; }

        public Timer(int seconds,int times,TimerDelegate method)
        {
            this.seconds = seconds;
            this.times = times;
            this.method = method;
        }

        public void RunTimer()
        {
            for(int i=0;i<times;i++)
            {
                method();
                Thread.Sleep(seconds * 1000);
               
            }
        }
    }
}
