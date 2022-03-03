using System;

namespace Binary2
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
            //will Complete Tommorow
        //}
        public Program()
        {
            Show();           
        }
        static void Show()
        {
            Program p = new Program();
            Console.Write("Enter The Number:");
            int num = p.ReadInt();
            int temp = num;
            string st = " ";
            while (num != 0)
            {
                int rem = num % 2;
                st = rem + st;
                num /= 2;
            }
            Console.WriteLine(temp + "Binary Value is:" + st);
        }
    }
}
