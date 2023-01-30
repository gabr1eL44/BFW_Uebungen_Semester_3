using System;

namespace BFW_Uebungen_Semester_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start Current Task
            A1.Start();

            // Wait for KeyPress
            Console.WriteLine("\nDrücken Sie eine beliebige Taste, um dieses Fenster zu schließen.");
            ConsoleKeyInfo taste = Console.ReadKey();
            if (taste.Key == ConsoleKey.Enter)
                return;
        }
    }
}