//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace netcentric.delegates
//{
//    internal class Delegates
//    {
//        public delegate void AddNum(int a, int b);
//        public delegate void SubNum(int a, int b);

//        public void sum(int a, int b)
//        {
//            Console.WriteLine("(100 + 40) = {0}", a + b);
//        }

//        public void subtract(int a, int b)
//        {
//            Console.WriteLine("(100 - 60) = {0}", a - b);
//        }


//        public static void Main(string[] args)
//        {
//            Delegates obj = new Delegates();

//            AddNum del_obj1 = new AddNum(obj.sum);
//            SubNum del_obj2 = new SubNum(obj.subtract);
//            del_obj1(100, 40);
//            del_obj2(100, 60);
//        }
//    }
//}
