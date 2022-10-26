using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    class Pen
    {
        public string color;
        public string brand;
        public double height;
        public double width;

        public void write()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("This is Write Method");
            Console.WriteLine("Color : " + color);
            Console.WriteLine("Brand : " + brand);
            Console.WriteLine("Height : " +height);
            Console.WriteLine("Width : " + width);
            Console.WriteLine("------------------");// new operator works memory alocation
        }
    }
}
