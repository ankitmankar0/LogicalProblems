using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;

namespace MonthlyPaym
{
    internal class Program
    {
            public static void Main(string[] args)
            {
                Input.MonthlyPayment();
                Console.ReadLine();

            }
        }
    class Input
    {
        public static void MonthlyPayment()
        {
            Console.WriteLine("Enter principle");
            double p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter years");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter rate");
            double R = Convert.ToInt32(Console.ReadLine());
            int n = 12 * y;
            double r = (R / (12 * 100));
            double s = 1 + r;
            double power = (double)Math.Pow(s, -n);
            double payment = (p * r) / power;
            Console.WriteLine("Monthly payment is :{0}", payment);
        }




    }
}

