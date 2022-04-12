using System;

namespace Temprature

{
    class TemperatureConversion
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit;
            Console.WriteLine("Enter value for celsius:"); //40
            celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value for Fahrenheit:");  // 80
            fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celToFah = (celsius * 9 / 5) + 32;  // 40*9/5=72+32=104
            double fahToCel = (fahrenheit - 32) * 5 / 9; //80-32=48*5/9= 26.6
            Console.WriteLine("After celsius to fahrenheit conversion: {0}", celToFah);
            Console.WriteLine("After fahrenheit to celsius conversion: {0}", fahToCel);

        }

    }

}

