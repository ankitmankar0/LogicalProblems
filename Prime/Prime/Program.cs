using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");  /// 3
            int number = Convert.ToInt32(Console.ReadLine());
            int result = Check_Prime(number);
            if (result == 0)
            {
                Console.WriteLine("{0} is not a prime number", number);
            }
            else
            {
                Console.WriteLine("{0} is  a prime number", number);
            }
            Console.Read();
        }

        private static int Check_Prime(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++) // i = 2
            {
                if (number % i == 0)  // if r = 0 then its not prime
                {
                    return 0;
                }
            }
            if (i == number) /// i3 = 3 then prime
            {
                return 1;
            }
            return 0;
        }
    }
}
