using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

  
namespace _1.DefineClass
{
    
    class Battery
    {
        private string model;
        private string hoursIdle; 
        private string hourseTalk;
        private BatteryType batteryType;

        public Battery(string model, string hourseIdle, string hourseTalk,BatteryType batteryType)
        {
            this.Model = model;
            this.HoursIdle = hourseIdle;
            this.HourseTalk = hourseTalk;
            this.BatteryType = batteryType;
        }

        public string Model {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid model!");
                this.model = value;
            }
        }
        public string HoursIdle {
            get { return this.hoursIdle; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid hours!");
                this.hoursIdle = value;
            }
        }
        public string HourseTalk {
            get { return this.hourseTalk;}
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid hours!");
                this.hourseTalk = value;
            }
        }
        public BatteryType BatteryType {
            get { return this.batteryType;}
            set
            {
                if(!(Enum.IsDefined(typeof(BatteryType),value)))
                    throw new ArgumentException("Invalid battery type!");
                this.batteryType=value;
            }
        }

        public override string ToString()
        {
            return "[Battery]"+"\n"+"Model: " + this.model + "\n" +
            "HoursIdle: " + this.hoursIdle + "\n" +
            "HoursTalk: " + this.hoursIdle + "\n" +
            "Battery type: " + this.batteryType + "\n";
        }
    }
       public enum BatteryType
    {
        LiIon,
        NiMH, 
        NiCd
    }

    
 

}
