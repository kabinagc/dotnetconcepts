//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace netcentric.AccessModifier
//{
//    public class AccessModifier
//    {

//        public int PublicNumber = 10;
//        private int PrivateNumber = 20;
//        protected int ProtectedNumber = 30;
//        internal int InternalNumber = 50;
//        protected internal int ProtectedInternalNumber = 100;

//        public void ShowNumbers()
//        {
//            Console.WriteLine("PublicNumber: " + PublicNumber);
//            Console.WriteLine("PrivateNumber: " + PrivateNumber);
//            Console.WriteLine("ProtectedNumber: " + ProtectedNumber);
//            Console.WriteLine("InternalNumber: " + InternalNumber);
//            Console.WriteLine("ProtectedInternalNumber: " + ProtectedInternalNumber);
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            AccessModifier access = new AccessModifier();
//            access.ShowNumbers();
//        }
//    }
//}
