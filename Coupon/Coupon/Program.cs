using System;
using System.Collections.Generic;
using System.Linq;

namespace Coupon
{
    class Program
        {
            static void Main(string[] args)
            {
                int couponStart, couponEnd;
                //Get range for coupon from user
                Console.WriteLine("Enter start range of coupon number");
                couponStart = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter End range of coupon number");
                couponEnd = Convert.ToInt32(Console.ReadLine());
                Random random = new Random();
                int randomNumber = random.Next(couponStart, couponEnd);
            List<int> number = new List<int>();
                number.Add(randomNumber);
                List<int> distinct = number.Distinct().ToList();
                foreach (int i in distinct)
                {
                    Console.WriteLine(" Distinct coupon nummber is :" + i);
                }
            }
        }
    
}
