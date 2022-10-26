using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    class B:A
    {
        public Int32 y;
        public Int32 x = 50;//Bx but display Ax
        public B()
        {
            this.y = 10;
        }
        public void gety()
        {
            Console.WriteLine("By::" + this.y);
        }
        public void getx()
        {
            Int32 x = 15;
            Console.WriteLine("Ax::" + base.x);//access parent class.
            Console.WriteLine("Ax::" + this.x);
            Console.WriteLine("Bx Local ::" + x);
            base.getx();
        }
    }
}
