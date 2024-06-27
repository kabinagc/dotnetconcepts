using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcentric.Inheritance
{
    class Class2 : Class1
    {
        public void Test3()
            {
            Console.WriteLine("Method 3");
        }
        static void Main()
        {
            Class2 c = new Class2();
            c.Test1();
            c.Test2();
            c.Test3();
            Console.ReadLine();
        }
    }
}
