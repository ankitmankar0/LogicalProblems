

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    class MonthlyPayment
    {
        public static void GetMonthlyPayment()
        {
            Console.WriteLine("Enter the value of principal amount: ");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the year: ");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the rate : ");
            double R = Convert.ToDouble(Console.ReadLine());

            double n = 12 * Y;
            double r = R / (12 * 100);
            double payment = P * r / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine(payment + "is monthly payment");
        }
    }
    class Program
    {
            public static void Main(string[] args)
            {
                MonthlyPayment.GetMonthlyPayment();
                Console.ReadLine();
            }
        }
}
