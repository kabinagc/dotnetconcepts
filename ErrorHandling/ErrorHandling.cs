﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace netcentric.ErrorHandling
//{
//    internal class ExceptionHandling
//    { 
//        static void Main(string[] args)
//        {
//            try
//            {
//                Console.WriteLine("Enter a number:");
//                int num = int.Parse(Console.ReadLine());

//                int result = 10 / num;
//                Console.WriteLine($"Result: {result}");
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Invalid input. Please enter a valid number.");
//            }
//            catch (DivideByZeroException)
//            {
//                Console.WriteLine("Division by zero is not allowed.");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"An error occurred: {ex.Message}");
//            }
//            finally
//            {
//                Console.WriteLine("Program execution completed.");
//            }
//        }
//    }
//}
