using System;

namespace sqrroot
{    
       class program
        {
            public static void Main(string[] args)
            {
                Sqrt.ReadInput();
            }
        }
        class Sqrt
        {
            public static void ReadInput()
            {
                //Read input from user
                Console.WriteLine("Enter value of c");
                double c = Convert.ToDouble(Console.ReadLine());
                SquareRoot(c);
            }
            private static void SquareRoot(double c)
            {
                //Given: local variables
                double t = c;
            //Given l= 1e^-15 = 0.0000000000000011
                double l = 0.0000000000000011;
                double sqrtValue;

                while (true)
                {
                    //Compute average of c/t and t
                    sqrtValue = 0.5 * (t + (c / t));
                    if (Math.Abs(sqrtValue - t) < l)
                    {
                        break;
                    }
                    t = sqrtValue;
                }
                Console.WriteLine("Root Value is :" + t);


            }
        }
    
}
//double c = u.ReadDouble();
//Double t = c;
//double epsilon = 1 * Math.Pow(10, -15);
//while (Math.Abs(t - c / t) > epsilon * t)
//{
//    t = (t + c / t) / 2;
//}
//Console.WriteLine("Square root of " + c + " is: " + t)

