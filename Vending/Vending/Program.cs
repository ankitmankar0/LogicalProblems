using System;

namespace Vending
{

    public class VendingMachine
    {
        public VendingMachine()
        {
            Console.WriteLine("Enter money amount:");
            int money = Convert.ToInt32(Console.ReadLine());
            int[] notes = new int[] { 1, 2, 5, 10, 50, 500, 1000 };
            int length = notes.Length;
            Program u = new Program();
            Console.WriteLine("Minimum Notes= " + Program.MinNotes(notes, length, money));
        }
    }
}
