using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DefineClass
{
    class GSMTest
    {
        static void main(string[] args)
        {
            GSM[] array = new GSM[2];
            array[0] = new GSM(420, "josh", "samsungs5", "samsung", new Battery("13h293", "250", "320", BatteryType.LiIon), new Display("4.7", "320k"));
            array[1] = new GSM(550, "james", "lumia", "nokia", new Battery("931c2", "320", "520", BatteryType.NiMH), new Display("5.1", "120k"));

            foreach (GSM gsm in array)
            {
                Console.WriteLine(gsm.ToString());
            }
            Console.WriteLine(GSM.Iphone4S.ToString());

        }
    }
}
