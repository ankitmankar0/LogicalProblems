// See https://aka.ms/new-console-template for more information
using System;
namespace VendingMachine
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("minimum number of notes to give change");
            int Number = Convert.ToInt32(Console.ReadLine());
            int remainder = Number;  ///215
            int[] Array = new int[8] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            foreach (int note in Array)
            {
                int i = 0;
                while (remainder >= note)  // 215 > 1000, 500 , 100 etc // r = 115 >100 // 15 > 100 go in result and check for other note//
                {
                    remainder -= note; //  215-100 = 115 // 115-100=15 // 15-10=5 //
                    i++;
                }
                string result = i > 0 ? $"{note} X {i} = {note * i}" : "-";
                Console.WriteLine(result);
            }
        }
    }
}

