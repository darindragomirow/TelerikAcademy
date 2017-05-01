using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DefineClass
{
     class GSM
    {

            private string model;
            private string manifacturer;
            private double price;
            private string owner;
            //Battery
            private Battery battery;
            //Display
            private Display display;
            //Static Field Iphone4S
            private static  GSM iphone4S=new GSM(500,"John","Iphone4S","Apple",
                new Battery("15123","2500","1000",BatteryType.LiIon),new Display("15.4","250k"));
            //Call history
            internal List<Call> CallHistory=new List<Call>();

            //First Constructor
            public GSM(string model, string manifacturer)
            {
                this.Model = model;
                this.Manifacturer = manifacturer;
                this.price = 0.0;
                this.owner = null;
            }
            //Second Constructor
            public GSM (double price, string owner,string model, string manifacturer,Battery b,Display d)
                :this(model,manifacturer)
                
            {
                this.Price = price;
                this.Owner = owner;
                this.battery = b;
                this.display = d;
            }

            //Declaring Getters and Setters for the fields
            public string Model
            {
                get { return this.model; }
                set
                {
                    if (String.IsNullOrEmpty(value))
                        throw new ArgumentException("Invalid model!");
                    this.model = value;
                }
            }
            public string Manifacturer {
                get { return this.manifacturer; }
                set
                {
                    if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid manifacturer!");
                    this.manifacturer = value;
                }
            }
            public double Price {
                get { return this.price; }
                set
                {
                    if(Double.IsNaN(value))
                        throw new ArgumentException("Not a number!");
                    this.price=value;
                }
            }
            public string Owner {
                get { return this.owner; }
                set {
                    if (String.IsNullOrEmpty(value))
                        throw new ArgumentException("Invalid owner!");
                    this.owner = value;
                }
            }
            public Battery Battery
            {
                get { return this.battery; }
                set
                {
                    if (value != null)
                        this.battery = value;
                }
            }
            public Display Display
            {
                get { return this.display; }
                set
                {
                    if (value != null)
                        this.display = value;
                }
            }
            public static GSM Iphone4S
            {
                get { return iphone4S; }
                set
                {
                    if (value != null)
                        iphone4S = value;
                }


            }



            //Overriding ToString()...
            public override string ToString()
            {
                return "[GSM]" + "\n" + "Model: " + this.model +"\n"+"Manifacturer: "+this.manifacturer+"\n" + "Price: " + this.price + "\n" +
                    "Owner: " + this.owner + "\n"+battery.ToString()+display.ToString();
            }

            //Add or Delete Call
        public void AddCall(Call call)
            {
                CallHistory.Add(call);
            }
        public void DeleteCall(Call call)
        {
            CallHistory.Remove(call);
        }
        //Delete the whole history
        public void DeleteCallHistory()
        {
            CallHistory.Clear();
            Console.WriteLine("The Call history was deleted!");
        }
        //Call Price
        public void CalculateCallPrice(double pricePerMinute)
        {
            double totalPrice = 0;
            int totalDuration=0;
            foreach(Call call in CallHistory)
            {
                totalDuration += call.Duration;
            }
            totalPrice =(double)((int)(totalDuration / 60)) * pricePerMinute;
            Console.WriteLine("The total price for all calls is: {0:F2}",totalPrice);
        }





        }
}
