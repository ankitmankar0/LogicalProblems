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
            int remainder = Number;
            int[] Array = new int[8] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            foreach (int note in Array)
            {
                int i = 0;
                while (remainder >= note)
                {
                    remainder -= note;
                    i++;
                }
                string result = i > 0 ? $"{note} X {i} = {note * i}" : "-";
                Console.WriteLine(result);
            }
        }
    }
}

