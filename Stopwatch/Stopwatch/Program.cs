using System;
using System.Diagnostics;
using System.Threading;

namespace Day_6_PracticeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new stopwatch
            Stopwatch stopWatch = new Stopwatch(); // Stopwatch class is defined in sys.Dignostics namespace
            //Begin Timimg
            stopWatch.Start();
            //do something
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }
            //stop timing
            stopWatch.Stop();
            //printing result
            Console.WriteLine("Time Elapsed:{0}", stopWatch.Elapsed);

        }
    }
}
