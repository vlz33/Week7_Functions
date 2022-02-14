﻿using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene arv:");
            int userNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teine arv:");
            int userNumberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vali tehe: '+', '-', '*' või '/'");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '+':
                    AddTwoNumbers(userNumberTwo, userNumberTwo);
                    break;
                case '-':
                    SubtractTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '*':
                    MultiplyTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '/':
                    DivideTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                default:
                    Console.WriteLine("Kena päeva");
                    break;
            }
        }

        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }

        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }
        public static void SubtractTwoNumbers(double x, double y)
        {
            double result = x - y;
            Console.WriteLine(result);
        }
        public static void MultiplyTwoNumbers(double x, double y)
        {
            double result = x * y;
            Console.WriteLine(result);
        }



    }
}
