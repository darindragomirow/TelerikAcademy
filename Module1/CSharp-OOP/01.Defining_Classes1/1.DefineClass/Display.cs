using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DefineClass
{
    public class Display
    {
        private string size;
        private string numberOfColors;
       
        public Display(string size,string numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public string Size
        {
            get { return this.size; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid size!");
                this.size = value;
            }
        }

        public string NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid size!");
                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            return "[Display]"+"\n"+"Size: " + this.size + "\n" +
                "Number of colors: " + this.numberOfColors + "\n";
              
        }

    }
}
