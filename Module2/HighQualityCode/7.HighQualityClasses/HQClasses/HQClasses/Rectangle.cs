using System;

namespace Abstraction
{
    class Rectangle : Figure
    {
        private double width, height;
        public Rectangle()  
        {
        }

        public Rectangle(double width, double height) 
        {
            this.Width = width;
            this.Height = height;           
        }
        public double Width
        {
            get { return this.width; }
            set
            {
                if (value >= 0)
                {
                    this.width = value;
                }
                else throw new ArgumentException("Width must be positive number!");
            }
        }
        public double Height
        {
            get { return this.height; }
            set
            {
                if (value >= 0)
                {
                    this.height = value;
                }
                else throw new ArgumentException("Height must be positive number!");
            }
        }



        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
