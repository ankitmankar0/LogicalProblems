using System;

namespace Fibonacci
{
    internal class Program
    {
        public static void Main(string[] args)
        {   
            
            int num1 = 0, num2 = 1, num3, i, n;
            Console.WriteLine("Enter the Value of n:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci series:");
            Console.Write(num1 + " " + num2 + " ");
            for (i = 2; i < n; i++)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }
        }
    }
}