using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DefineClass
{
    //It should contain date, time, dialled phone number and duration (in seconds).
    class Call
    {
        private DateTime date;
        private string dialledNumber;
        private int duration;

        public Call(DateTime date,string dialledNumber,int duration)
        {
            this.Date = date;
            this.DialledNumber = dialledNumber;
            this.Duration = duration;
        }
        public DateTime Date
        {
            get { return this.date; }
            set
            {
                this.date = value;
            }
        }
        public string DialledNumber
        {
            get { return this.dialledNumber; }
            set
            {
                if (value.Length == 10)
                {
                    this.dialledNumber = value;
                }
                else throw new ArgumentException("Invalid number!");
            }
        }
        public int Duration
        {
            get { return this.duration; }
            set
            {
                this.duration = value;
            }
        }

        public override string ToString()
        {
            return "[Call]" + "\n" + "Date:" + this.date.Date +"\n" + "Dialled number:"+this.dialledNumber
            +"\n" + "Duration:" + this.duration+"\n";
        }
    }
}
