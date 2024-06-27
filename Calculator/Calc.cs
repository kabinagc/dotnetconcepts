//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace netcentric.Calculator
//{
//    internal class Calc
//    {
//        static void Main(string[] args)
//        {
//            string value;
//            do
//            {
//                int res;
//                Console.Write("Enter first number:");
//                int num1 = Convert.ToInt32(Console.ReadLine());
//                Console.Write("Enter second numbr:");
//                int num2 = Convert.ToInt32(Console.ReadLine());
//                Console.Write("Enter the symbol of the operation you wanna do(/,+,-,*):");
//                string symbol = Console.ReadLine();

//                switch (symbol)
//                {
//                    case "+":
//                        res = num1 + num2;
//                        Console.WriteLine("The sum is " + res);
//                        break;
//                    case "-":
//                        res = num1 - num2;
//                        Console.WriteLine("The difference is " + res);
//                        break;
//                    case "*":
//                        res = num1 * num2;
//                        Console.WriteLine("The multification is " + res);
//                        break;
//                    case "/":
//                        res = num1 / num2;
//                        Console.WriteLine("The division is" + res);
//                        break;
//                    default:
//                        Console.WriteLine("Wrong input");
//                        break;
//                }

//                Console.ReadLine();
//                Console.Write("Do you want to continue(y/n): ");
//                value = Console.ReadLine();

//            }
//            while (value == "y" || value == "Y");
//        }
//    }
//}


