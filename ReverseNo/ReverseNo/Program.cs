﻿using System;

namespace ReverseNo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a No. to reverse");
            int Number = int.Parse(Console.ReadLine());
            int Reverse = 0;
            while (Number > 0)
            {
                int remainder = Number % 10;    //124 % 10  R = 4
                Reverse = (Reverse * 10) + remainder;   //  0=0*10+4
                Number = Number / 10;  // 124/10 = 12
            }
            Console.WriteLine("Reverse No. is {0}", Reverse);
            Console.ReadLine();
        }
    }
}