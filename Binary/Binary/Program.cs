using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System;

namespace ToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("decimal to binary");
            Console.WriteLine("enetr number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            GetBinary(number);

        }

        public static void GetBinary(int number)
        {
            List<int> binaryList = new List<int>();
            int power2 = 2;
            while (number > power2)
            {
                power2 *= 2;
            }

            while (power2 > 0)
            {
                if (number >= power2)
                {
                    number -= power2;
                    binaryList.Add(1);
                }
                else
                {
                    binaryList.Add(0);
                }
                power2 /= 2;
            }

            Console.WriteLine(string.Join(" ", binaryList));
        }
    }
}
