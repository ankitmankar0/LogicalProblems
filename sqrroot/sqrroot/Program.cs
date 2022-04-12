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
                Console.WriteLine("Enter value of c");   ///        9
                double c = Convert.ToDouble(Console.ReadLine());
                SquareRoot(c);
            }
            private static void SquareRoot(double c)
            {
                //Given: local variables
                double t = c;  ///    t=9  and c=9
            //Given l= 1e^-15 = 0.0000000000000011
                double l = 0.0000000000000011;
                double sqrtValue;

                while (true)
                {
                    //Compute average of c/t and t
                    sqrtValue = 0.5 * (t + (c / t));   // 0.5 * (9+(9/9)) = 0.5 * 10 = 5  //  0.5 *(5+(9/5)) = 0.5 * 6.8 = 3.4 // 0.5*(3.4+(9/3.4))=0.5(3.4+2.64) = 6.04/0.5=3.02
                    if (Math.Abs(t - sqrtValue ) < l)   //  9-5 =4 < L ,  false // 5-3.4=1.6<l false; // 3.4-3.02= <l false // 
                    {
                        break;
                    }
                    t = sqrtValue; // t=5, // t = 3.4 // t=3.02
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

